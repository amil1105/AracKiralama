--
-- PostgreSQL database dump
--

-- Dumped from database version 15.5
-- Dumped by pg_dump version 16.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: arac_bakima_alindi_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.arac_bakima_alindi_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- kullanimdurumu tablosundaki ilgili aracın durumunu 'BAKIMDA' olarak güncelle
    UPDATE kullanimdurumu
    SET kullanim_durumu = 'BAKIMDA'
    WHERE arac_plaka = NEW.arac_plaka;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.arac_bakima_alindi_tetikleyici() OWNER TO postgres;

--
-- Name: arac_hasar_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.arac_hasar_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    
    UPDATE kullanimdurumu
    SET kullanim_durumu = 'HASARLI'
    WHERE arac_plaka = NEW.arac_plaka;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.arac_hasar_tetikleyici() OWNER TO postgres;

--
-- Name: arac_plaka_buyukharf_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.arac_plaka_buyukharf_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   
    NEW.plaka := UPPER(NEW.plaka);

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.arac_plaka_buyukharf_tetikleyici() OWNER TO postgres;

--
-- Name: arac_teslim_et(bigint, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.arac_teslim_et(p_tc bigint, p_plaka character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM "KiralamaSozlesmesi"
    WHERE musteri_tc = p_tc AND plaka = p_plaka;

    UPDATE kullanimdurumu
    SET kullanim_durumu = 'BOŞ'
    WHERE arac_plaka = p_plaka;
END;
$$;


ALTER FUNCTION public.arac_teslim_et(p_tc bigint, p_plaka character varying) OWNER TO postgres;

--
-- Name: kullanici_personel_ekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kullanici_personel_ekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    
    INSERT INTO kullanici(kullanici_tc, sifre, yetki)
    VALUES (NEW.tc, NEW.tc::varchar, NEW.gorevi);

  
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.kullanici_personel_ekle() OWNER TO postgres;

--
-- Name: musterihasargecmisi(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.musterihasargecmisi(tc_param bigint) RETURNS TABLE(hasar_id integer, arac_plaka character varying, hasar_tarihi date, hasar_aciklamasi text, hasar_ucreti integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT
        hasar.id as hasar_id,
        hasar.arac_plaka,
        hasar.hasar_tarihi,
        hasar.hasar_aciklamasi,
        hasar.hasar_ucreti
    FROM
        "HasarTablosu" hasar
    WHERE
        hasar."yapanKisi" = tc_param;
END;
$$;


ALTER FUNCTION public.musterihasargecmisi(tc_param bigint) OWNER TO postgres;

--
-- Name: musterikiralamagecmisibul(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.musterikiralamagecmisibul(tc_param bigint) RETURNS TABLE(kiralama_id integer, plaka character varying, marka character varying, seri character varying, yil integer, renk character varying, gun smallint, fiyat integer, tutar integer, tarih1 date, tarih2 date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT
        kiralama.id as kiralama_id,
        kiralama.plaka,
        kiralama.marka,
        kiralama.seri,
        kiralama.yil,
        kiralama.renk,
        kiralama.gun,
        kiralama.fiyat,
        kiralama.tutar,
        kiralama.tarih1,
        kiralama.tarih2
    FROM
        "KiralamaGecmisi" kiralama
    WHERE
        kiralama.musteri_tc = tc_param;
END;
$$;


ALTER FUNCTION public.musterikiralamagecmisibul(tc_param bigint) OWNER TO postgres;

--
-- Name: personel_ekleme_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.personel_ekleme_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO public.kullanici (kullanici_tc, sifre, yetki)
    VALUES (NEW.tc, MD5(NEW.tc::TEXT), NEW.gorevi);
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.personel_ekleme_tetikleyici() OWNER TO postgres;

--
-- Name: personel_ekleme_ve_silme_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.personel_ekleme_ve_silme_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Yeni personel eklemek için
    IF TG_OP = 'INSERT' AND NEW."kisiTipi" = 'P' THEN
        INSERT INTO public.kullanici (kullanici_tc, sifre, yetki)
        VALUES (NEW.tc, NEW.telefon::TEXT, NEW.gorevi);
    END IF;

    -- Eski personeli silmek için
    IF TG_OP = 'DELETE' AND OLD."kisiTipi" = 'P' THEN
        DELETE FROM public.kullanici
        WHERE kullanici_tc = OLD.tc;
    END IF;

    RETURN NULL;
END;
$$;


ALTER FUNCTION public.personel_ekleme_ve_silme_tetikleyici() OWNER TO postgres;

--
-- Name: personel_gorev_guncelle_tetikleyici(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.personel_gorev_guncelle_tetikleyici() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Yeni görevi kullanıcı yetkisi olarak ayarla
    UPDATE public.kullanici
    SET yetki = NEW.gorevi
    WHERE kullanici_tc = NEW.tc;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.personel_gorev_guncelle_tetikleyici() OWNER TO postgres;

--
-- Name: toplam_kiralama_tutari(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.toplam_kiralama_tutari() RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    toplam_tutar integer;
BEGIN
    SELECT COALESCE(SUM(tutar), 0) INTO toplam_tutar
    FROM "KiralamaGecmisi";

    RETURN toplam_tutar;
END;
$$;


ALTER FUNCTION public.toplam_kiralama_tutari() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: AracBakim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."AracBakim" (
    id integer NOT NULL,
    arac_plaka character varying(10) NOT NULL,
    bakim_tarihi date NOT NULL,
    bakim_aciklamasi text,
    bakim_ucreti integer NOT NULL
);


ALTER TABLE public."AracBakim" OWNER TO postgres;

--
-- Name: AracBakim_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."AracBakim_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."AracBakim_id_seq" OWNER TO postgres;

--
-- Name: AracBakim_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."AracBakim_id_seq" OWNED BY public."AracBakim".id;


--
-- Name: FaturaTablo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."FaturaTablo" (
    id integer NOT NULL,
    satis_id integer NOT NULL,
    tutar integer NOT NULL,
    odeme_tarihi date,
    odeme_durumu boolean DEFAULT false NOT NULL,
    islem_tarihi date NOT NULL
);


ALTER TABLE public."FaturaTablo" OWNER TO postgres;

--
-- Name: FaturaTablo_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."FaturaTablo_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."FaturaTablo_id_seq" OWNER TO postgres;

--
-- Name: FaturaTablo_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."FaturaTablo_id_seq" OWNED BY public."FaturaTablo".id;


--
-- Name: HasarTablosu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."HasarTablosu" (
    id integer NOT NULL,
    arac_plaka character varying(10) NOT NULL,
    "yapanKisi" bigint NOT NULL,
    hasar_tarihi date NOT NULL,
    hasar_aciklamasi text,
    hasar_ucreti integer NOT NULL
);


ALTER TABLE public."HasarTablosu" OWNER TO postgres;

--
-- Name: KiraSekliTablo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."KiraSekliTablo" (
    id integer NOT NULL,
    adi character varying(40) NOT NULL,
    "indirimYuzdesi" smallint DEFAULT '0'::smallint NOT NULL
);


ALTER TABLE public."KiraSekliTablo" OWNER TO postgres;

--
-- Name: KiraSekliTablo_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."KiraSekliTablo_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."KiraSekliTablo_id_seq" OWNER TO postgres;

--
-- Name: KiraSekliTablo_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."KiraSekliTablo_id_seq" OWNED BY public."KiraSekliTablo".id;


--
-- Name: KiralamaGecmisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."KiralamaGecmisi" (
    id integer NOT NULL,
    musteri_tc bigint NOT NULL,
    adsoyad character varying(20) NOT NULL,
    plaka character varying(10) NOT NULL,
    marka character varying NOT NULL,
    seri character varying(20) NOT NULL,
    yil integer NOT NULL,
    renk character varying(20) NOT NULL,
    gun smallint NOT NULL,
    fiyat integer NOT NULL,
    tutar integer NOT NULL,
    tarih1 date NOT NULL,
    tarih2 date NOT NULL
);


ALTER TABLE public."KiralamaGecmisi" OWNER TO postgres;

--
-- Name: KiralamaGecmisi_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."KiralamaGecmisi_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."KiralamaGecmisi_id_seq" OWNER TO postgres;

--
-- Name: KiralamaGecmisi_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."KiralamaGecmisi_id_seq" OWNED BY public."KiralamaGecmisi".id;


--
-- Name: KiralamaSozlesmesi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."KiralamaSozlesmesi" (
    id integer NOT NULL,
    musteri_tc bigint NOT NULL,
    ehliyetno bigint NOT NULL,
    plaka character varying(10) NOT NULL,
    kirasekli integer NOT NULL,
    gun smallint NOT NULL,
    tutar integer NOT NULL,
    ctarih date NOT NULL,
    dtarih date NOT NULL,
    kiraucreti integer NOT NULL
);


ALTER TABLE public."KiralamaSozlesmesi" OWNER TO postgres;

--
-- Name: YakitDurumu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."YakitDurumu" (
    id integer NOT NULL,
    arac_plaka character varying(10) NOT NULL,
    "yakitTipi" character varying(20) NOT NULL,
    "ortalamaTuketim" smallint NOT NULL,
    kalanlitre smallint NOT NULL
);


ALTER TABLE public."YakitDurumu" OWNER TO postgres;

--
-- Name: YakitDurumu_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."YakitDurumu_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."YakitDurumu_id_seq" OWNER TO postgres;

--
-- Name: YakitDurumu_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."YakitDurumu_id_seq" OWNED BY public."YakitDurumu".id;


--
-- Name: arac; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.arac (
    plaka character varying(10) NOT NULL,
    marka character varying(20) NOT NULL,
    seri character varying(20) NOT NULL,
    renk character varying(30) NOT NULL,
    km integer NOT NULL,
    yakitdurumu integer,
    kullanimdurumu integer,
    kiraucreti integer NOT NULL,
    yil smallint NOT NULL
);


ALTER TABLE public.arac OWNER TO postgres;

--
-- Name: kullanimdurumu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kullanimdurumu (
    id integer NOT NULL,
    arac_plaka character varying(10) NOT NULL,
    kullanim_durumu character varying(10) NOT NULL
);


ALTER TABLE public.kullanimdurumu OWNER TO postgres;

--
-- Name: araclarinkullanimdurumu_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.kullanimdurumu ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.araclarinkullanimdurumu_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: ehliyet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ehliyet (
    ehliyetno bigint NOT NULL,
    tc bigint NOT NULL,
    alinmatarihi date NOT NULL,
    verildigisehir integer NOT NULL
);


ALTER TABLE public.ehliyet OWNER TO postgres;

--
-- Name: kisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kisi (
    tc bigint NOT NULL,
    adsoyad character varying(40) NOT NULL,
    telefon bigint NOT NULL,
    adres text,
    dogumtarihi date NOT NULL,
    email character varying(40),
    ehliyetno integer NOT NULL,
    kisitipi character(1) NOT NULL
);


ALTER TABLE public.kisi OWNER TO postgres;

--
-- Name: kullanici; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kullanici (
    kullanici_tc bigint NOT NULL,
    sifre character varying(50) NOT NULL,
    yetki character varying(20) NOT NULL
);


ALTER TABLE public.kullanici OWNER TO postgres;

--
-- Name: musteri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.musteri (
    tc bigint NOT NULL
);


ALTER TABLE public.musteri OWNER TO postgres;

--
-- Name: personel; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.personel (
    maas integer,
    gorevi character varying(20),
    tc bigint NOT NULL
);


ALTER TABLE public.personel OWNER TO postgres;

--
-- Name: sehir; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sehir (
    id integer NOT NULL,
    "SehirAdi" character varying(20) NOT NULL
);


ALTER TABLE public.sehir OWNER TO postgres;

--
-- Name: table1_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.table1_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.table1_id_seq OWNER TO postgres;

--
-- Name: table1_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.table1_id_seq OWNED BY public."KiralamaSozlesmesi".id;


--
-- Name: table1_id_seq1; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.table1_id_seq1
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.table1_id_seq1 OWNER TO postgres;

--
-- Name: table1_id_seq1; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.table1_id_seq1 OWNED BY public."HasarTablosu".id;


--
-- Name: AracBakim id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracBakim" ALTER COLUMN id SET DEFAULT nextval('public."AracBakim_id_seq"'::regclass);


--
-- Name: FaturaTablo id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."FaturaTablo" ALTER COLUMN id SET DEFAULT nextval('public."FaturaTablo_id_seq"'::regclass);


--
-- Name: HasarTablosu id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."HasarTablosu" ALTER COLUMN id SET DEFAULT nextval('public.table1_id_seq1'::regclass);


--
-- Name: KiraSekliTablo id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiraSekliTablo" ALTER COLUMN id SET DEFAULT nextval('public."KiraSekliTablo_id_seq"'::regclass);


--
-- Name: KiralamaGecmisi id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiralamaGecmisi" ALTER COLUMN id SET DEFAULT nextval('public."KiralamaGecmisi_id_seq"'::regclass);


--
-- Name: KiralamaSozlesmesi id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiralamaSozlesmesi" ALTER COLUMN id SET DEFAULT nextval('public.table1_id_seq'::regclass);


--
-- Name: YakitDurumu id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."YakitDurumu" ALTER COLUMN id SET DEFAULT nextval('public."YakitDurumu_id_seq"'::regclass);


--
-- Data for Name: AracBakim; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."AracBakim" (id, arac_plaka, bakim_tarihi, bakim_aciklamasi, bakim_ucreti) FROM stdin;
17	54BAH48	2023-12-26	genel	2500
18	54BAH48	2023-12-26	motor	5500
19	54BAH48	2023-12-26	yağ	6000
16	54BAH48	2020-12-26	yağ değişimi	6000
20	34TCP54	2023-12-26	yağ değişme	12000
\.


--
-- Data for Name: FaturaTablo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."FaturaTablo" (id, satis_id, tutar, odeme_tarihi, odeme_durumu, islem_tarihi) FROM stdin;
16	41	500	2023-12-26	t	2023-12-30
15	39	480	2023-12-26	t	2023-12-30
14	37	800	2023-12-26	t	2023-12-30
17	43	500	2023-12-26	t	2023-12-30
18	45	800	\N	f	2023-12-30
19	47	500	\N	f	2023-12-30
\.


--
-- Data for Name: HasarTablosu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."HasarTablosu" (id, arac_plaka, "yapanKisi", hasar_tarihi, hasar_aciklamasi, hasar_ucreti) FROM stdin;
8	34TCP54	98527388990	2023-12-26	ön tampon	12500
10	54BAH48	98527388990	2021-12-26	motor	2500
9	34TCP54	24656802582	2023-12-26	ayna	2500
12	54BAH48	53648585714	2023-12-26	arka tampon	5500
13	34TC034	99982851090	2023-12-26	pert	15000
\.


--
-- Data for Name: KiraSekliTablo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."KiraSekliTablo" (id, adi, "indirimYuzdesi") FROM stdin;
3	Günlük	0
4	Haftalık	20
5	Aylık	30
\.


--
-- Data for Name: KiralamaGecmisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."KiralamaGecmisi" (id, musteri_tc, adsoyad, plaka, marka, seri, yil, renk, gun, fiyat, tutar, tarih1, tarih2) FROM stdin;
36	55252456521	MOHAMMED ALKERDİ	34TCP54	BMW	530i	2015	beyaz	4	200	800	2023-12-26	2023-12-30
37	55252456521	MOHAMMED ALKERDİ	34TCP54	BMW	530i	2015	beyaz	4	200	800	2023-12-26	2023-12-30
38	99982851090	BASHAR EID	99XX299	Mercedes	C220	2001	Lacivert	4	120	480	2023-12-26	2023-12-30
39	99982851090	BASHAR EID	99XX299	Mercedes	C220	2001	Lacivert	4	120	480	2023-12-26	2023-12-30
40	99517598555	HUSEYN EMİRALİZADE	34AZE54	Renault	CLİO	2015	beyaz	4	125	500	2023-12-26	2023-12-30
41	99517598555	HUSEYN EMİRALİZADE	34AZE54	Renault	CLİO	2015	beyaz	4	125	500	2023-12-26	2023-12-30
42	52409528053	Burak Kara	34BAZ48	Renault	CLİO	2015	beyaz	4	125	500	2023-12-26	2023-12-30
43	52409528053	Burak Kara	34BAZ48	Renault	CLİO	2015	beyaz	4	125	500	2023-12-26	2023-12-30
44	38997469832	Elif Çelik	34TCP54	BMW	530i	2015	beyaz	4	200	800	2023-12-26	2023-12-30
45	38997469832	Elif Çelik	34TCP54	BMW	530i	2015	beyaz	4	200	800	2023-12-26	2023-12-30
46	99982851090	BASHAR EID	34TCC54	FİAT	Linea	2015	beyaz	4	150	500	2023-12-26	2023-12-30
47	99982851090	BASHAR EID	34TCC54	FİAT	Linea	2015	beyaz	4	150	500	2023-12-26	2023-12-30
\.


--
-- Data for Name: KiralamaSozlesmesi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."KiralamaSozlesmesi" (id, musteri_tc, ehliyetno, plaka, kirasekli, gun, tutar, ctarih, dtarih, kiraucreti) FROM stdin;
51	94558194054	60391350	34AZE48	3	4	500	2023-12-26	2023-12-30	125
52	94558194054	60391350	34BAH49	3	4	500	2023-12-26	2023-12-30	125
53	99982851090	24565	34TCP54	3	16	3200	2023-12-26	2024-01-11	200
\.


--
-- Data for Name: YakitDurumu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."YakitDurumu" (id, arac_plaka, "yakitTipi", "ortalamaTuketim", kalanlitre) FROM stdin;
19	10AA935	Benzin	15	60
27	34CHH48	Benzin	8	50
31	34BAZ48	Benzin	8	50
32	34AZE48	Benzin	8	50
33	34AZE54	Benzin	8	50
34	34TCP54	Benzin	12	50
35	34BAH45	Dizel	8	50
36	34BAH49	Benzin	8	50
37	34BAH51	Benzin	8	50
38	34BAH52	Benzin	8	50
22	34TC034	Benzin	60	50
28	34HPP48	Benzin	12	80
25	34TCC54	Benzin + LPG	12	50
29	54BAH48	Benzin	8	60
23	99XX299	Dizel	13	40
\.


--
-- Data for Name: arac; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.arac (plaka, marka, seri, renk, km, yakitdurumu, kullanimdurumu, kiraucreti, yil) FROM stdin;
34BAZ48	Renault	CLİO	beyaz	65000	31	24	125	2015
34AZE48	Renault	CLİO	beyaz	65000	32	25	125	2015
34AZE54	Renault	CLİO	beyaz	65000	33	26	125	2015
34TCP54	BMW	530i	beyaz	65000	34	27	200	2015
34BAH45	Renault	CLİO	beyaz	65000	35	28	125	2015
34BAH49	Renault	CLİO	beyaz	65000	36	29	125	2015
34BAH51	Renault	CLİO	beyaz	65000	37	30	125	2015
34BAH52	Renault	CLİO	beyaz	65000	38	31	125	2015
34TC034	Ford	Mustang	kırmızı	85000	22	15	350	2013
34HPP48	FİAT	Linea	beyaz	85000	28	21	150	2015
34TCC54	FİAT	Linea	beyaz	150000	25	18	150	2015
10AA935	Mercedes	E300	Siyah	300000	19	12	100	1995
54BAH48	FİAT	Linea	beyaz	85000	29	22	150	2015
99XX299	Mercedes	C220	Lacivert	455000	23	16	120	2001
34CHH48	FİAT	Linea	beyaz	85000	27	20	150	2015
\.


--
-- Data for Name: ehliyet; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ehliyet (ehliyetno, tc, alinmatarihi, verildigisehir) FROM stdin;
254546	99395643999	2023-12-25	4
254654	99517598555	2022-12-25	82
524654	55252456521	2021-12-25	31
24565	99982851090	2001-12-21	34
524545	98527388990	2023-12-25	21
25372000	16852512665	2020-03-23	34
57199097	18416504545	2002-11-12	35
24191989	19421243065	2003-01-09	34
65469363	19546094081	2004-01-14	34
55713587	24656802582	2001-11-10	35
10412976	27129173913	2002-10-02	5
86319100	33281842233	2011-08-22	34
17893813	36067003495	2021-08-24	34
45535931	38205363993	2016-03-25	35
98747562	38661810584	2001-03-04	34
91819602	38997469832	2013-05-02	34
57426571	42005514903	2005-09-23	35
15549926	50264841111	2016-10-18	34
28937866	52409528053	2000-11-06	34
26734138	53648585714	2011-10-15	34
77499501	55857650015	2004-08-17	34
17563330	56210036927	2000-05-17	34
94798037	56395758758	2005-02-06	34
28674876	68310183112	2022-09-14	34
34306571	71880746013	2007-02-03	35
29855744	80001877564	2005-04-14	35
17239584	83236455737	2010-07-07	34
98875755	90568062955	2003-06-11	34
79729310	91529202662	2010-03-20	34
99391681	92979943023	2008-06-04	34
60391350	94558194054	2000-02-15	1
3323332	44812397054	2021-12-24	54
452654	99517397000	2022-07-07	82
2332221	99395643125	2021-12-24	24
214554	55257397990	2022-12-24	5
\.


--
-- Data for Name: kisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kisi (tc, adsoyad, telefon, adres, dogumtarihi, email, ehliyetno, kisitipi) FROM stdin;
99395643999	Ahmet Yılmaz	5012545454	sakarya	1999-12-25		254546	P
56210036927	Burak Öztürk	586204360	Adres 96	1999-07-18	email1550@mail.com	17563330	M
56395758758	Alirıza Öztürk	582214390	Adres 78	1976-08-11	email5399@mail.com	94798037	M
99517598555	HUSEYN EMİRALİZADE	5015955454	Bakü	2004-09-02	hhhh1@gmail.com	254654	M
68310183112	Ahmet Çelik	515373849	Adres 65	1997-06-15	email8130@mail.com	28674876	M
71880746013	Veli Özdemir	558443681	Adres 44	1971-06-17	email2452@mail.com	34306571	M
55252456521	MOHAMMED ALKERDİ	5462458565	Hatay	2003-05-24		524654	M
99982851090	BASHAR EID	332333212	istanbul	2001-12-27	crazy1@gmal.com	24565	M
98527388990	Mahir Ayar	5019997499	istanbul	1999-12-01		524545	P
80001877564	Emre Özdemir	500872722	Adres 13	1994-07-06	email8232@mail.com	29855744	M
16852512665	Ahmet Kara	568131479	Adres 43	1964-08-14	email4098@mail.com	25372000	M
18416504545	Veli Yıldız	539266086	Adres 48	1975-04-20	email5831@mail.com	57199097	M
19421243065	Ahmet Çelik	541699697	Adres 43	1961-07-18	email6176@mail.com	24191989	M
19546094081	Ahmet Demir	578356870	Adres 17	1994-05-16	email8494@mail.com	65469363	M
24656802582	Zeynep Öztürk	569289407	Adres 49	1975-01-09	email3175@mail.com	55713587	M
27129173913	Elif Kaya	535409926	Adres 5	1963-08-19	email1731@mail.com	10412976	M
33281842233	Elif Yıldız	593219370	Adres 77	1980-03-27	email2725@mail.com	86319100	M
36067003495	Ali Öztürk	574697545	Adres 52	1966-06-16	email9145@mail.com	17893813	M
38205363993	Emre Aksoy	590574188	Adres 30	1998-10-17	email9300@mail.com	45535931	M
38661810584	Ali Yıldız	555082323	Adres 69	1995-07-11	email2020@mail.com	98747562	M
83236455737	Ayşe Yıldız	542482694	Adres 99	1989-11-23	email4096@mail.com	17239584	M
90568062955	Ali Yılmaz	560378032	Adres 5	1983-05-13	email6629@mail.com	98875755	M
38997469832	Elif Çelik	560145485	Adres 89	1963-09-02	email1058@mail.com	91819602	M
91529202662	Fatma Öztürk	578370390	Adres 82	2000-08-02	email6914@mail.com	79729310	M
92979943023	Emre Aksoy	527689003	Adres 77	1979-06-15	email3028@mail.com	99391681	M
94558194054	Fatma Öztürk	545040998	Adres 34	2000-01-20	email8847@mail.com	60391350	M
42005514903	Ali Kaya	568110869	Adres 60	1974-03-11	email2634@mail.com	57426571	M
50264841111	Mehmet Kara	561942079	Adres 33	1964-08-22	email7126@mail.com	15549926	M
52409528053	Burak Kara	503230557	Adres 46	1982-11-24	email9513@mail.com	28937866	M
53648585714	Elif Çelik	502334771	Adres 1	1971-06-11	email7028@mail.com	26734138	M
55857650015	Burak Yılmaz	522202020	Adres 13	1972-02-06	email6725@mail.com	77499501	M
44812397054	Samet Yılmaz	50158425	Sakarya	1999-11-02	yilmaz@mail.com	3323332	P
99517397000	Amil Shikhiyev	5012607454	istanbul	2005-07-27	sxiyev4@gmail.com	452654	P
99395643125	Burak Kaan	5012608888	sakarya	2000-05-01		2332221	P
55257397990	Koray Han	2602133232	istanbul	2001-12-24		214554	P
\.


--
-- Data for Name: kullanici; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kullanici (kullanici_tc, sifre, yetki) FROM stdin;
98527388990	98527388990	şöför
44812397054	12345	Müdür
99517397000	1234	Yönetici
99395643125	99395643125	şöfor
55257397990	1234	şöför
\.


--
-- Data for Name: kullanimdurumu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kullanimdurumu (id, arac_plaka, kullanim_durumu) FROM stdin;
18	34TCC54	BOŞ
22	54BAH48	BOŞ
25	34AZE48	DOLU
29	34BAH49	DOLU
27	34TCP54	DOLU
12	10AA935	BOŞ
21	34HPP48	BOŞ
28	34BAH45	BOŞ
30	34BAH51	BOŞ
31	34BAH52	BOŞ
16	99XX299	BOŞ
26	34AZE54	BOŞ
20	34CHH48	BOŞ
24	34BAZ48	BOŞ
15	34TC034	HASARLI
\.


--
-- Data for Name: musteri; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.musteri (tc) FROM stdin;
99982851090
99517598555
55252456521
16852512665
18416504545
19421243065
19546094081
24656802582
27129173913
33281842233
36067003495
38205363993
38661810584
38997469832
42005514903
50264841111
52409528053
53648585714
55857650015
56210036927
56395758758
68310183112
71880746013
80001877564
83236455737
90568062955
91529202662
92979943023
94558194054
\.


--
-- Data for Name: personel; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.personel (maas, gorevi, tc) FROM stdin;
15000	şöför	98527388990
15000	Müdür	44812397054
0	Yönetici	99517397000
15000	şöfor	99395643125
20000	şöför	55257397990
\.


--
-- Data for Name: sehir; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.sehir (id, "SehirAdi") FROM stdin;
1	Adana
2	Adıyaman
3	Afyonkarahisar
4	Ağrı
5	Amasya
6	Ankara
7	Antalya
8	Artvin
9	Aydın
10	Balıkesir
11	Bilecik
12	Bingöl
13	Bitlis
14	Bolu
15	Burdur
16	Bursa
17	Çanakkale
18	Çankırı
19	Çorum
20	Denizli
21	Diyarbakır
22	Edirne
23	Elazığ
24	Erzincan
25	Erzurum
26	Eskişehir
27	Gaziantep
28	Giresun
29	Gümüşhane
30	Hakkâri
31	Hatay
32	Isparta
33	İçel (Mersin)
34	İstanbul
35	İzmir
36	Kars
37	Kastamonu
38	Kayseri
39	Kırklareli
40	Kırşehir
41	Kocaeli
42	Konya
43	Kütahya
44	Malatya
45	Manisa
46	Kahramanmaraş
47	Mardin
48	Muğla
49	Muş
50	Nevşehir
51	Niğde
52	Ordu
53	Rize
54	Sakarya
55	Samsun
56	Siirt
57	Sinop
58	Sivas
59	Tekirdağ
60	Tokat
61	Trabzon
62	Tunceli
63	Şanlıurfa
64	Uşak
65	Van
66	Yozgat
67	Zonguldak
68	Aksaray
69	Bayburt
70	Karaman
71	Kırıkkale
72	Batman
73	Şırnak
74	Bartın
75	Ardahan
76	Iğdır
77	Yalova
78	Karabük
79	Kilis
80	Osmaniye
81	Düzce
82	Diğer (Yurtdışı)
\.


--
-- Name: AracBakim_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."AracBakim_id_seq"', 20, true);


--
-- Name: FaturaTablo_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."FaturaTablo_id_seq"', 19, true);


--
-- Name: KiraSekliTablo_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."KiraSekliTablo_id_seq"', 5, true);


--
-- Name: KiralamaGecmisi_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."KiralamaGecmisi_id_seq"', 47, true);


--
-- Name: YakitDurumu_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."YakitDurumu_id_seq"', 39, true);


--
-- Name: araclarinkullanimdurumu_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.araclarinkullanimdurumu_id_seq', 32, true);


--
-- Name: table1_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.table1_id_seq', 53, true);


--
-- Name: table1_id_seq1; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.table1_id_seq1', 13, true);


--
-- Name: AracBakim AracBakim_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracBakim"
    ADD CONSTRAINT "AracBakim_pkey" PRIMARY KEY (id);


--
-- Name: KiraSekliTablo KiraSekliTablo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiraSekliTablo"
    ADD CONSTRAINT "KiraSekliTablo_pkey" PRIMARY KEY (id);


--
-- Name: KiralamaGecmisi KiralamaGecmisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiralamaGecmisi"
    ADD CONSTRAINT "KiralamaGecmisi_pkey" PRIMARY KEY (id);


--
-- Name: kisi kisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT kisi_pkey PRIMARY KEY (tc);


--
-- Name: kullanici kullanici_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanici
    ADD CONSTRAINT kullanici_pkey PRIMARY KEY (kullanici_tc);


--
-- Name: personel personel_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT personel_pkey PRIMARY KEY (tc);


--
-- Name: sehir sehir_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sehir
    ADD CONSTRAINT sehir_pkey PRIMARY KEY (id);


--
-- Name: KiralamaSozlesmesi table1_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiralamaSozlesmesi"
    ADD CONSTRAINT table1_pkey PRIMARY KEY (id);


--
-- Name: HasarTablosu table1_pkey1; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."HasarTablosu"
    ADD CONSTRAINT table1_pkey1 PRIMARY KEY (id);


--
-- Name: YakitDurumu unique_YakitDurumu_yakit_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."YakitDurumu"
    ADD CONSTRAINT "unique_YakitDurumu_yakit_id" PRIMARY KEY (id);


--
-- Name: arac unique_arac_plaka; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.arac
    ADD CONSTRAINT unique_arac_plaka PRIMARY KEY (plaka);


--
-- Name: kullanimdurumu unique_araclarinkullanimdurumu_arac_plaka; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanimdurumu
    ADD CONSTRAINT unique_araclarinkullanimdurumu_arac_plaka UNIQUE (arac_plaka);


--
-- Name: kullanimdurumu unique_araclarinkullanimdurumu_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanimdurumu
    ADD CONSTRAINT unique_araclarinkullanimdurumu_id PRIMARY KEY (id);


--
-- Name: ehliyet unique_ehliyet_ehliyetno; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ehliyet
    ADD CONSTRAINT unique_ehliyet_ehliyetno PRIMARY KEY (ehliyetno);


--
-- Name: ehliyet unique_ehliyet_tc; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ehliyet
    ADD CONSTRAINT unique_ehliyet_tc UNIQUE (tc);


--
-- Name: kisi unique_kisi_tc; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT unique_kisi_tc UNIQUE (tc);


--
-- Name: musteri unique_musteri_tc; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteri
    ADD CONSTRAINT unique_musteri_tc PRIMARY KEY (tc);


--
-- Name: personel unique_personel_tc; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT unique_personel_tc UNIQUE (tc);


--
-- Name: AracBakim arac_bakima_alindi_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER arac_bakima_alindi_trigger AFTER INSERT ON public."AracBakim" FOR EACH ROW EXECUTE FUNCTION public.arac_bakima_alindi_tetikleyici();


--
-- Name: HasarTablosu arac_hasar_tetikleyici_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER arac_hasar_tetikleyici_trigger AFTER INSERT ON public."HasarTablosu" FOR EACH ROW EXECUTE FUNCTION public.arac_hasar_tetikleyici();


--
-- Name: arac arac_plaka_buyukharf_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER arac_plaka_buyukharf_trigger BEFORE INSERT OR UPDATE ON public.arac FOR EACH ROW EXECUTE FUNCTION public.arac_plaka_buyukharf_tetikleyici();


--
-- Name: personel personel_gorev_guncelle_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER personel_gorev_guncelle_trigger AFTER UPDATE OF gorevi ON public.personel FOR EACH ROW EXECUTE FUNCTION public.personel_gorev_guncelle_tetikleyici();


--
-- Name: personel trigger_kullanici_personel_ekle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trigger_kullanici_personel_ekle AFTER INSERT ON public.personel FOR EACH ROW EXECUTE FUNCTION public.kullanici_personel_ekle();


--
-- Name: HasarTablosu aracHasar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."HasarTablosu"
    ADD CONSTRAINT "aracHasar" FOREIGN KEY (arac_plaka) REFERENCES public.arac(plaka) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kullanimdurumu aracKullanim; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanimdurumu
    ADD CONSTRAINT "aracKullanim" FOREIGN KEY (arac_plaka) REFERENCES public.arac(plaka) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: YakitDurumu aracYakit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."YakitDurumu"
    ADD CONSTRAINT "aracYakit" FOREIGN KEY (arac_plaka) REFERENCES public.arac(plaka) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: AracBakim aracbakim; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracBakim"
    ADD CONSTRAINT aracbakim FOREIGN KEY (arac_plaka) REFERENCES public.arac(plaka) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: ehliyet ehliyetSehir; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ehliyet
    ADD CONSTRAINT "ehliyetSehir" FOREIGN KEY (verildigisehir) REFERENCES public.sehir(id) MATCH FULL;


--
-- Name: FaturaTablo gecmisFatura; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."FaturaTablo"
    ADD CONSTRAINT "gecmisFatura" FOREIGN KEY (satis_id) REFERENCES public."KiralamaGecmisi"(id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: ehliyet kisiehliyet; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ehliyet
    ADD CONSTRAINT kisiehliyet FOREIGN KEY (tc) REFERENCES public.kisi(tc) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: musteri kisimusteri; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteri
    ADD CONSTRAINT kisimusteri FOREIGN KEY (tc) REFERENCES public.kisi(tc) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: personel kisipersonel; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT kisipersonel FOREIGN KEY (tc) REFERENCES public.kisi(tc) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kullanici personelKullanici; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanici
    ADD CONSTRAINT "personelKullanici" FOREIGN KEY (kullanici_tc) REFERENCES public.personel(tc) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: KiralamaSozlesmesi sozlesmeKiraSekli; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."KiralamaSozlesmesi"
    ADD CONSTRAINT "sozlesmeKiraSekli" FOREIGN KEY (kirasekli) REFERENCES public."KiraSekliTablo"(id) MATCH FULL;


--
-- PostgreSQL database dump complete
--

