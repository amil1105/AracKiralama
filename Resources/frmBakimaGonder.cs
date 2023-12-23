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
    public partial class frmBakimaGonder : Form
    {
        AracKiralama arac = new AracKiralama();
        public frmBakimaGonder(TextBox txtPlakaa, TextBox txtMarkaa, TextBox txtRenkk, TextBox txtSerii, TextBox txtYill, TextBox txtKMm)
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void yenile()
        {
            string sorgu = @"select bakim_aciklamasi,bakim_tarihi,bakim_ucreti from ""AracBakim"" where arac_plaka='" + txtPlaka.Text + "'";
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, sorgu);
            txtBakimTarihi.Text = "";
            txtBakimUcreti.Text = "";
            txtAciklama.Text = "";
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnEkle.Visible = true;
        }
        private void frmBakimaGonder_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "AÇIKLAMA";
            dataGridView1.Columns[1].HeaderText = "TARİHİ";
            dataGridView1.Columns[2].HeaderText = "ÜCRETİ";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBakimTarihi.Text != "" && txtBakimUcreti.Text != "" && txtAciklama.Text != "")
            {
                string sorgu = @"insert into ""AracBakim""(arac_plaka,bakim_aciklamasi,bakim_tarihi,bakim_ucreti) values(@arac_plaka,@bakim_aciklamasi,@bakim_tarihi,@bakim_ucreti)";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@arac_plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@bakim_aciklamasi", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@bakim_tarihi", DateTime.Parse(txtBakimTarihi.Text));
                cmd.Parameters.AddWithValue("@bakim_ucreti", int.Parse(txtBakimUcreti.Text));
                arac.ekle_sil_guncelle(cmd, sorgu);
                yenile();
                kullanimKontrol();

            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtAciklama.Text = satir.Cells[0].Value.ToString();
            txtBakimTarihi.Text = satir.Cells[1].Value.ToString();
            txtBakimUcreti.Text = satir.Cells[2].Value.ToString();
            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnEkle.Visible = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = @"delete from ""AracBakim"" where arac_plaka='" + txtPlaka.Text + "'";
            NpgsqlCommand cmd = new NpgsqlCommand();

            arac.ekle_sil_guncelle(cmd, sorgu);
            yenile();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = @"update ""AracBakim"" set bakim_aciklamasi=@bakim_aciklamasi,bakim_tarihi=@bakim_tarihi,bakim_ucreti=@bakim_ucreti where arac_plaka='" + txtPlaka.Text + "'";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@bakim_aciklamasi", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@bakim_tarihi", DateTime.Parse(txtBakimTarihi.Text));
            cmd.Parameters.AddWithValue("@bakim_ucreti", int.Parse(txtBakimUcreti.Text));
            arac.ekle_sil_guncelle(cmd, sorgu);
            yenile();
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
                cmd.Parameters.AddWithValue("@kullanim_durumu", "BAKIMDA");
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
    }
}
