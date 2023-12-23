using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmMusteriEkle : Form
    {
        private AracKiralama aracKiralama = new AracKiralama();
        public frmMusteriEkle()
        {
            InitializeComponent();
            aracKiralama.SehirleriGetir(txtE_yer, "select * from sehir");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool bosMu = false;
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.Text == "")
                    bosMu = true;
            }
            if (!bosMu)
            {
                string kisiSorgu = "INSERT INTO kisi(tc, adsoyad, telefon, adres, dogumtarihi, email, ehliyetno, kisitipi) VALUES (@tc, @adsoyad, @telefon, @adres, @dogumtarihi, @email, @ehliyetno, @kisitipi)";
                NpgsqlCommand kisikomut = new NpgsqlCommand();
                kisikomut.Parameters.AddWithValue("@tc", long.Parse(txtTc.Text));
                kisikomut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
                kisikomut.Parameters.AddWithValue("@telefon", long.Parse(txtTelefon.Text));
                kisikomut.Parameters.AddWithValue("@adres", txtAdres.Text);
                kisikomut.Parameters.AddWithValue("@dogumtarihi", DateTime.Parse(dateTimeDogumTarihi.Text));
                kisikomut.Parameters.AddWithValue("@email", txtEmail.Text);
                kisikomut.Parameters.AddWithValue("@ehliyetno", long.Parse(txtEhliyetNo.Text));
                kisikomut.Parameters.AddWithValue("@kisitipi", 'M');

                aracKiralama.ekle_sil_guncelle(kisikomut, kisiSorgu);

                string musterisorgu = "INSERT INTO musteri(tc) VALUES (@tc)";
                NpgsqlCommand musterikomut = new NpgsqlCommand();
                musterikomut.Parameters.AddWithValue("@tc", long.Parse(txtTc.Text));

                aracKiralama.ekle_sil_guncelle(musterikomut, musterisorgu);


                NpgsqlCommand ehliyetkomut = new NpgsqlCommand();
                string ehliyetsorgu = "INSERT INTO ehliyet(ehliyetno, alinmatarihi, tc, verildigiSehir) VALUES (@ehliyetno, @alinmatarihi, @tc, @verildigisehir)";

                ehliyetkomut.Parameters.AddWithValue("@ehliyetno", long.Parse(txtEhliyetNo.Text));
                ehliyetkomut.Parameters.AddWithValue("@alinmatarihi", DateTime.Parse(dateTimeE_tarih.Text));
                ehliyetkomut.Parameters.AddWithValue("@tc", long.Parse(txtTc.Text));
                ehliyetkomut.Parameters.AddWithValue("@verildigisehir", txtE_yer.Text);

                aracKiralama.ekle_sil_guncelle(ehliyetkomut, ehliyetsorgu);

                TxtKayitBasari.Text = "KAYIT BAŞARILI";
                MessageBox.Show("Müşteri Ekledi!");
                foreach (Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
             
               


        


            private void txtTc_TextChanged(object sender, EventArgs e)
        {
            TxtKayitBasari.Text = "";

        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtAdsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
