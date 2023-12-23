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
    kirasekli character varying(20) NOT NULL,
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
    verildigisehir character varying(20) NOT NULL
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
-- Name: kullanici PersonelKullanici; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kullanici
    ADD CONSTRAINT "PersonelKullanici" FOREIGN KEY (kullanici_tc) REFERENCES public.personel(tc) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


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
-- PostgreSQL database dump complete
--

