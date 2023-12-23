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

namespace AracKiralama.Resources
{
    public partial class frmHasarKaydi : Form
    {
        AracKiralama arac = new AracKiralama();
        public frmHasarKaydi(TextBox txtPlakaa, TextBox txtMarkaa, TextBox txtRenkk, TextBox txtSerii, TextBox txtYill, TextBox txtKMm)
        {
            InitializeComponent();

            txtPlaka.Text = txtPlakaa.Text;
            txtMarka.Text = txtMarkaa.Text;
            txtRenk.Text = txtRenkk.Text;
            txtSeri.Text = txtSerii.Text;
            txtYil.Text = txtYill.Text;
            txtKM.Text = txtKMm.Text;
            yenile();
            kullanimKontrol();
        }
        private void yenile() 
        {
            string sorgu = @"select hasar_aciklamasi,hasar_tarihi,""yapanKisi"",hasar_ucreti from ""HasarTablosu"" where arac_plaka='" + txtPlaka.Text + "'";
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, sorgu);

            txtHasarTarihi.Text = "";
            txtHasarUcreti.Text = "";
            txtAciklama.Text = "";
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnEkle.Visible = true;
        }
        private void frmHasarKaydi_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "AÇIKLAMA";
            dataGridView1.Columns[1].HeaderText = "TARİHİ";
            dataGridView1.Columns[2].HeaderText = "YAPAN KİŞİ";
            dataGridView1.Columns[3].HeaderText = "ÜCRETİ";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtHasarTarihi.Text != "" && txtHasarUcreti.Text != "" && txtAciklama.Text != "")
            {
                string sorgu = @"insert into ""HasarTablosu""(arac_plaka,hasar_aciklamasi,hasar_tarihi,hasar_ucreti,""yapanKisi"") values(@arac_plaka,@hasar_aciklamasi,@hasar_tarihi,@hasar_ucreti,@yapanKisi)";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@arac_plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@hasar_aciklamasi", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@hasar_tarihi", DateTime.Parse(txtHasarTarihi.Text));
                cmd.Parameters.AddWithValue("@hasar_ucreti", int.Parse(txtHasarUcreti.Text));
                cmd.Parameters.AddWithValue("@yapanKisi", long.Parse(txtTCara.Text));

                arac.ekle_sil_guncelle(cmd, sorgu);
                yenile();
                kullanimKontrol();


            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {
            string sorgu2 = @"select * from kisi where CAST(tc AS TEXT) like '" + txtTCara.Text + "%'";

            arac.TC_ara(txtTc,txtE_No, txtAdsoyad, txtTelefon, txtAdres,txtEmail,txtDogumT, sorgu2);
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtAciklama.Text = satir.Cells[0].Value.ToString();
            txtHasarUcreti.Text = satir.Cells[1].Value.ToString();
            txtTCara.Text = satir.Cells[2].Value.ToString();
            txtHasarUcreti.Text = satir.Cells[3].Value.ToString();

            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnEkle.Visible = false;
        }

        private void checkBoxKullanim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKullanim.Checked)
            {
                string sorgu2 = @"update kullanimdurumu set kullanim_durumu=@kullanim_durumu where arac_plaka='" + txtPlaka.Text + "'";
                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.Parameters.AddWithValue("@kullanim_durumu", "BOŞ");
                arac.ekle_sil_guncelle(cmd2, sorgu2);
                yenile();


            }
            else
            {
                string sorgu1 = @"update kullanimdurumu set kullanim_durumu=@kullanim_durumu where arac_plaka='" + txtPlaka.Text + "'";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@kullanim_durumu", "HASARLI");
                arac.ekle_sil_guncelle(cmd, sorgu1);
                yenile();
            }
        }
        public void kullanimKontrol()
        {
            string sorgu = @"select * from kullanimdurumu where ""arac_plaka""= '" + txtPlaka.Text + "'";
            string bilgi = arac.bilgiGetir(sorgu, "kullanim_durumu");
            if (bilgi == "BOŞ")
                checkBoxKullanim.Checked = true;
            else checkBoxKullanim.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
