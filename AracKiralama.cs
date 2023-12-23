using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    internal class AracKiralama
    {
        public NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; Database=AracKiralama; User Id=postgres ;Password=1234;");
        DataTable tablo;

        public void ekle_sil_guncelle(NpgsqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void ekle_sil_guncelle2(NpgsqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
           // baglanti.Close();
        }

        public DataTable listele(NpgsqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new NpgsqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void BosAraclar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();

        }
        public void SehirleriGetir(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["SehirAdi"].ToString());
            }
            baglanti.Close();

        }

        public string bilgiGetir(string sorgu, string istenenKolon)
        {
            string okunanBilgi = "";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                okunanBilgi = read[istenenKolon].ToString();
            }



            baglanti.Close();
            return okunanBilgi;
        }

        public void TC_ara(Label tc, Label adsoyad, Label telefon, Label ehliyet, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
                ehliyet.Text = read["ehliyetno"].ToString();

            }
            baglanti.Close();
        }
        public void TC_ara(TextBox tc, TextBox ehliyet, TextBox adsoyad, TextBox telefon, TextBox adres, TextBox email, TextBox dogumT, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                ehliyet.Text = read["ehliyetno"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
                adres.Text = read["adres"].ToString();
                email.Text = read["email"].ToString();
                dogumT.Text = DateTime.Parse(read["dogumtarihi"].ToString()).ToShortDateString();

              


            }
            baglanti.Close();
        }
        public void Ehliyet_ara(Label tc, Label E_No, Label E_Yer, Label E_Tarih, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                E_No.Text = read["ehliyetno"].ToString();
                E_Yer.Text = read["verildigisehir"].ToString();
                E_Tarih.Text = read["alinmatarihi"].ToString();
            }
            baglanti.Close();
        }

        public void CombodanGetir(TextBox marka, TextBox seri, TextBox Yil, TextBox renk, TextBox kiraucreti, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                Yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
                kiraucreti.Text = read["kiraucreti"].ToString();


            }
            baglanti.Close();
        }

       
        public void kiraTurleriniGetir(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["adi"].ToString());
            }
            baglanti.Close();

        }


        public void IdArtir(Label lbl, string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            lbl.Text = komut.ExecuteScalar().ToString();
            NpgsqlDataReader read = komut.ExecuteReader();


            baglanti.Close();

        }


        public void satisHesapla(Label lbl)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(@"select toplam_kiralama_tutari()", baglanti);
            lbl.Text = "Toplam Tutar = " + komut.ExecuteScalar() + " TL ";
            baglanti.Close();



        }




    }
}
