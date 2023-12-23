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
    public partial class frmPersonelYonetim : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public frmPersonelYonetim()
        {
            InitializeComponent();
        }

        private void frmPersonelYonetim_Load(object sender, EventArgs e)
        {
            YenileList();
            aracKiralama.SehirleriGetir(txtE_yer, "select * from sehir");
            txtTc.ReadOnly = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileList();
            txtTc.ReadOnly = true;
        }

        private void YenileList()
        {
            string cumle = @"SELECT kt.tc, kt.adsoyad, kt.telefon, kt.adres, kt.DogumTarihi, kt.email, kt.ehliyetno, p.maas, p.gorevi FROM kisi kt INNER JOIN personel p ON kt.tc = p.tc WHERE kt.kisiTipi = 'P';";
            
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView2.DataSource = aracKiralama.listele(adtr2, cumle);
            dataGridView2.Columns[0].HeaderText = "TC";
            dataGridView2.Columns[1].HeaderText = "AD SOYAD";
            dataGridView2.Columns[2].HeaderText = "TELEFON";
            dataGridView2.Columns[3].HeaderText = "ADRES";
            dataGridView2.Columns[4].HeaderText = "DOĞUM TARİHİ";
            dataGridView2.Columns[5].HeaderText = "E-MAIL";
            dataGridView2.Columns[6].HeaderText = "EHLİYET NO";
            dataGridView2.Columns[7].HeaderText = "MAAŞ";
            dataGridView2.Columns[8].HeaderText = "Görevi";


            foreach (Control item in Controls)
                if (item is TextBox)
                    item.Text = "";
            foreach (Control item in Controls)
                if (item is ComboBox)
                    item.Text = "";

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

            NpgsqlCommand komut4 = new NpgsqlCommand();
            string cumle4 = "update personel set gorevi=@gorevi,maas=@maas where tc=" + long.Parse(txtTc.Text);

            komut4.Parameters.AddWithValue("@gorevi", txtGorevi.Text);
            komut4.Parameters.AddWithValue("@maas", long.Parse(txtMaas.Text));

            NpgsqlCommand komut3 = new NpgsqlCommand();
            string cumle3 = "update kullanici set sifre=@sifre,kullanici_tc=@kullanici_tc where kullanici_tc=@kullanici_tc";
          
            komut3.Parameters.AddWithValue("@kullanici_tc", long.Parse(txtTc.Text));
            komut3.Parameters.AddWithValue("@sifre", long.Parse(txtSifreK.Text));

            aracKiralama.ekle_sil_guncelle(komut1, cumle1);
            aracKiralama.ekle_sil_guncelle(komut2, cumle2);
            aracKiralama.ekle_sil_guncelle(komut3, cumle3);
            aracKiralama.ekle_sil_guncelle(komut4, cumle4);




            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            YenileList();




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

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            frmPersonelEkle ekle = new frmPersonelEkle();
            ekle.ShowDialog();
            YenileList();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
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

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdsoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            dateTimeDogumTarihi.Text = satir.Cells[4].Value.ToString();
            txtEmail.Text = satir.Cells[5].Value.ToString();
            txtEhliyetNo.Text = satir.Cells[6].Value.ToString();
            txtMaas.Text = satir.Cells[7].Value.ToString();
            txtGorevi.Text = satir.Cells[8].Value.ToString();


            string sorgu = "select * from ehliyet where ehliyetno=" + long.Parse(txtEhliyetNo.Text) + "";
            txtE_yer.Text = aracKiralama.bilgiGetir(sorgu, "verildigisehir");
            dateTimeE_tarih.Text = aracKiralama.bilgiGetir(sorgu, "alinmatarihi");

            string sorgu2 = "select * from kullanici where kullanici_tc=" + long.Parse(txtTc.Text) + "";
            txtSifreK.Text = aracKiralama.bilgiGetir(sorgu2, "sifre");


        }

        private void checkBoxSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked)
                txtSifreK.UseSystemPasswordChar = false;
            else
                txtSifreK.UseSystemPasswordChar = true;

        }

        private void txtTcArama_TextChanged_1(object sender, EventArgs e)
        {

            string cumle = @"SELECT kisi.tc, kisi.adsoyad, kisi.telefon, kisi.adres, kisi.dogumtarihi, kisi.email, kisi.ehliyetno FROM kisi INNER JOIN personel ON kisi.tc = personel.tc WHERE kisi.kisitipi = 'P' AND CAST(kisi.tc AS TEXT) LIKE '" + txtTcArama.Text + "%'";


            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView2.DataSource = aracKiralama.listele(adtr2, cumle);
        }
    }
}
