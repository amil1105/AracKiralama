using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmMusteriYonetim : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public frmMusteriYonetim()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileList();
            aracKiralama.SehirleriGetir(txtE_yer, "select * from sehir");
            txtTc.ReadOnly = true;
        }


        private void YenileList()
        {
            string cumle = "select tc, adsoyad, telefon, adres, dogumtarihi, email, ehliyetno from kisi where kisitipi='" + "M" + "'";
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView2.DataSource = aracKiralama.listele(adtr2, cumle);
            dataGridView2.Columns[0].HeaderText = "TC";
            dataGridView2.Columns[1].HeaderText = "AD SOYAD";
            dataGridView2.Columns[2].HeaderText = "TELEFON";
            dataGridView2.Columns[3].HeaderText = "ADRES";
            dataGridView2.Columns[4].HeaderText = "DOĞUM TARİHİ";
            dataGridView2.Columns[5].HeaderText = "E-MAIL";
            dataGridView2.Columns[6].HeaderText = "EHLİYET NO";

            foreach (Control item in Controls)
                if (item is TextBox) item.Text = "";

        }


        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdsoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            dateTimeDogumTarihi.Text = satir.Cells[4].Value.ToString();
            txtEmail.Text = satir.Cells[5].Value.ToString();
            txtEhliyetNo.Text = satir.Cells[6].Value.ToString();
            string sorgu = "select * from ehliyet where ehliyetno=" + long.Parse(txtEhliyetNo.Text) + "";
            txtE_yer.Text = aracKiralama.bilgiGetir(sorgu, "verildigisehir");
            dateTimeE_tarih.Text = aracKiralama.bilgiGetir(sorgu, "alinmatarihi");

            btnHasarGecmisi.Visible = true;
            btnKiralama.Visible = true;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle2 = "update kisi set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,dogumtarihi=@dogumtarihi,email=@email,ehliyetno=@ehliyetno where tc=@tc";

            NpgsqlCommand komut2 = new NpgsqlCommand();
            komut2.Parameters.AddWithValue("@tc", long.Parse(txtTc.Text));
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", long.Parse(txtTelefon.Text));
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@dogumtarihi", DateTime.Parse(dateTimeDogumTarihi.Text));
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", long.Parse(txtEhliyetNo.Text));
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);

            NpgsqlCommand komut1 = new NpgsqlCommand();
            string cumle1 = "update ehliyet set alinmatarihi=@alinmatarihi,tc=@tc,verildigisehir=@verildigisehir where ehliyetno=@ehliyetno";
            komut1.Parameters.AddWithValue("@ehliyetno", long.Parse(txtEhliyetNo.Text));
            komut1.Parameters.AddWithValue("@alinmatarihi", DateTime.Parse(dateTimeE_tarih.Text));
            komut1.Parameters.AddWithValue("@tc", long.Parse(txtTc.Text));
            komut1.Parameters.AddWithValue("@verildigisehir", txtE_yer.Text);

            aracKiralama.ekle_sil_guncelle(komut1, cumle1);
            aracKiralama.ekle_sil_guncelle(komut2, cumle2);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            YenileList();




        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bilgilerin Silinmesinden emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (cevap == DialogResult.Yes)
            {
                DataGridViewRow satir = dataGridView2.CurrentRow;
                string cumle = "delete from kisi where tc='" + satir.Cells["tc"].Value.ToString() + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand();
                aracKiralama.ekle_sil_guncelle(komut2, cumle);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";

                YenileList();
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtTcArama_TextChanged(object sender, EventArgs e)
        {


            string cumle = @"SELECT kisi.tc, kisi.adsoyad, kisi.telefon, kisi.adres, kisi.dogumtarihi, kisi.email, kisi.ehliyetno FROM kisi INNER JOIN musteri ON kisi.tc = musteri.tc WHERE kisi.kisitipi = 'M' AND CAST(kisi.tc AS TEXT) LIKE '" + txtTcArama.Text + "%'";


            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView2.DataSource = aracKiralama.listele(adtr2, cumle);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
            YenileList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriHasarGecmisi ekle = new frmMusteriHasarGecmisi(txtTc.Text);
            ekle.ShowDialog();
            YenileList();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            frmMusteriKiralamaGecmisi ekle = new frmMusteriKiralamaGecmisi(txtTc.Text);
            ekle.ShowDialog();
            YenileList();
        }
    }
}
