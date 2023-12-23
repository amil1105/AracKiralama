using AracKiralama.Resources;
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
    public partial class frmAracYonetim : Form
    {
        private AracKiralama aracKiralama = new AracKiralama();
        public frmAracYonetim()
        {
            InitializeComponent();

        }

        private void yenileAraclari()
        {

            labelDurumu.Text = "";
            string cumle = "select plaka,marka,seri,yil,renk,km,kiraucreti from arac";
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "PLAKA";
            dataGridView1.Columns[1].HeaderText = "MARKA";
            dataGridView1.Columns[2].HeaderText = "SERI";
            dataGridView1.Columns[3].HeaderText = "YIL";
            dataGridView1.Columns[4].HeaderText = "RENK";
            dataGridView1.Columns[5].HeaderText = "KM";
            dataGridView1.Columns[6].HeaderText = "ÜCRETİ";

            foreach (Control item in Controls)
                if (item is TextBox) item.Text = "";

            try
            {
                comboAraclar.SelectedIndex = 0;
            }
            catch
            {

            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnHasarKayit.Visible = false;
            btnBakimaGonder.Visible = false;


            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtPlaka.Text = satir.Cells[0].Value.ToString();
            txtMarka.Text = satir.Cells[1].Value.ToString();
            txtSeri.Text = satir.Cells[2].Value.ToString();
            txtYil.Text = satir.Cells[3].Value.ToString();
            txtRenk.Text = satir.Cells[4].Value.ToString();
            txtKM.Text = satir.Cells[5].Value.ToString();
            txtKiraUcreti.Text = satir.Cells[6].Value.ToString();

            string sorgu = @"select * from ""YakitDurumu"" where ""arac_plaka""= '" + txtPlaka.Text + "'";
            txtTuketim.Text = aracKiralama.bilgiGetir(sorgu, "kalanlitre");
            txtYakitmiktari.Text = aracKiralama.bilgiGetir(sorgu, @"ortalamaTuketim");
            ComboYakit.Text = aracKiralama.bilgiGetir(sorgu, "yakitTipi");
            string sorguD = @"select * from kullanimdurumu where ""arac_plaka""= '" + txtPlaka.Text + "'";
            
            labelDurumu.Text = "Durumu: " + aracKiralama.bilgiGetir(sorguD, "kullanim_durumu");

            if (!(aracKiralama.bilgiGetir(sorguD, "kullanim_durumu") == "DOLU"))
            {
                btnSil.Visible = true;
                btnGuncelle.Visible = true;
                btnHasarKayit.Visible = true;
                btnBakimaGonder.Visible = true;
            }
          






        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            yenileAraclari();
            txtPlaka.ReadOnly = true;
        }

       



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (comboAraclar.SelectedIndex == 0)
                {
                    yenileAraclari();
                }
                if (comboAraclar.SelectedIndex == 1)
                {
                    string cumle = "SELECT arac.plaka,arac.marka,arac.seri,arac.renk,arac.km,arac.kiraucreti,arac.yil FROM arac JOIN kullanimdurumu ON kullanimdurumu.arac_plaka = arac.plaka WHERE kullanimdurumu.kullanim_durumu = 'BOŞ';";
                    NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string cumle = "SELECT arac.plaka,arac.marka,arac.seri,arac.renk,arac.km,arac.kiraucreti,arac.yil FROM arac JOIN kullanimdurumu ON kullanimdurumu.arac_plaka = arac.plaka WHERE kullanimdurumu.kullanim_durumu = 'DOLU';";
                    NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);
                }
                if (comboAraclar.SelectedIndex == 3)
                {
                    string cumle = "SELECT arac.plaka,arac.marka,arac.seri,arac.renk,arac.km,arac.kiraucreti,arac.yil FROM arac JOIN kullanimdurumu ON kullanimdurumu.arac_plaka = arac.plaka WHERE kullanimdurumu.kullanim_durumu = 'BAKIMDA';";
                    NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);
                }
                if (comboAraclar.SelectedIndex == 4)
                {
                    string cumle = "SELECT arac.plaka,arac.marka,arac.seri,arac.renk,arac.km,arac.kiraucreti,arac.yil FROM arac JOIN kullanimdurumu ON kullanimdurumu.arac_plaka = arac.plaka WHERE kullanimdurumu.kullanim_durumu = 'HASARLI';";
                    NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);
                }
            }
            catch
            {

            }
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKiraUcreti_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmAracKayit frm = new frmAracKayit();
            frm.ShowDialog();
            yenileAraclari();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from arac where plaka= '" + satir.Cells[0].Value.ToString() + "'";
            NpgsqlCommand komut2 = new NpgsqlCommand();
            aracKiralama.ekle_sil_guncelle(komut2, cumle);
            aracKiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls)
                if (item is TextBox)
                    item.Text = "";
            foreach (Control item in Controls)
                if (item is ComboBox)
                    item.Text = "";
            yenileAraclari();
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnHasarKayit.Visible = false;
            btnBakimaGonder.Visible = false;

        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            string cumle = "update arac set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,kiraucreti=@kiraucreti where plaka=@plaka";
            NpgsqlCommand komut2 = new NpgsqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", int.Parse(txtYil.Text));
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@km", int.Parse(txtKM.Text));
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));

            aracKiralama.ekle_sil_guncelle(komut2, cumle);

           
            string cumleYakit = $"UPDATE \"YakitDurumu\" SET kalanlitre = {int.Parse(txtYakitmiktari.Text)},\"yakitTipi\" = '{ComboYakit.Text}',\"ortalamaTuketim\" = {int.Parse(txtTuketim.Text)} WHERE arac_plaka = '" + txtPlaka.Text.ToString() + "'";
            NpgsqlCommand komutYakit = new NpgsqlCommand();

            
            aracKiralama.ekle_sil_guncelle(komutYakit, cumleYakit);

            foreach (Control item in Controls)
                if (item is TextBox)
                    item.Text = "";
            foreach (Control item in Controls)
                if (item is ComboBox)
                    item.Text = "";
            yenileAraclari();
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnHasarKayit.Visible = false;
            btnBakimaGonder.Visible = false;

        }

        private void btnHasarKayit_Click(object sender, EventArgs e)
        {


            frmHasarKaydi frm = new frmHasarKaydi(txtPlaka, txtMarka, txtRenk, txtSeri, txtYil, txtKM);
            frm.ShowDialog();

            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnHasarKayit.Visible = false;
            btnBakimaGonder.Visible = false;

        }

        private void btnBakimaGonder_Click(object sender, EventArgs e)
        {
            frmBakimaGonder frm = new frmBakimaGonder(txtPlaka,txtMarka,txtRenk,txtSeri,txtYil,txtKM);
            frm.ShowDialog();



            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnHasarKayit.Visible = false;
            btnBakimaGonder.Visible = false;
        }
    }
}
