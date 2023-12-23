using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmAracKayit : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {
          
           


          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bosMu = false;
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.Text == "")
                    bosMu = true;
                if (item is ComboBox && item.Text == "")
                    bosMu = true;
            }
            if (!bosMu)
            {

                string aracSorgu = "insert into arac(plaka,marka,seri,yil,renk,km,kiraucreti) values(@plaka,@marka,@seri,@yil,@renk,@km,@kiraucreti)";

                NpgsqlCommand arackomut = new NpgsqlCommand();
                arackomut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                arackomut.Parameters.AddWithValue("@marka", txtMarka.Text);
                arackomut.Parameters.AddWithValue("@seri", txtSeri.Text);
                arackomut.Parameters.AddWithValue("@yil", int.Parse(txtYil.Text));
                arackomut.Parameters.AddWithValue("@renk", txtRenk.Text);
                arackomut.Parameters.AddWithValue("@km", int.Parse(txtKM.Text));
                arackomut.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));


                aracKiralama.ekle_sil_guncelle(arackomut, aracSorgu);

                string yakitSorgu = @"insert into ""YakitDurumu""(""arac_plaka"",kalanlitre,""ortalamaTuketim"",""yakitTipi"") values(@arac_plaka,@kalanlitre,@ortalamaTuketim,@yakitTipi)";
                NpgsqlCommand yakitkomut = new NpgsqlCommand();
                yakitkomut.Parameters.AddWithValue("@arac_plaka", txtPlaka.Text.ToUpper());
                yakitkomut.Parameters.AddWithValue("@kalanlitre", int.Parse(txtYakitmiktari.Text));
                yakitkomut.Parameters.AddWithValue("@ortalamaTuketim", int.Parse(txtTuketim.Text));
                yakitkomut.Parameters.AddWithValue("@yakitTipi", ComboYakit.Text);

                aracKiralama.ekle_sil_guncelle(yakitkomut, yakitSorgu);

                string kullanimSorgu = @"insert into kullanimdurumu(""arac_plaka"",kullanim_durumu) values(@arac_plaka,@kullanim_durumu)";
                NpgsqlCommand kullanimKomut = new NpgsqlCommand();
                kullanimKomut.Parameters.AddWithValue("@arac_plaka", txtPlaka.Text.ToUpper());
                kullanimKomut.Parameters.AddWithValue("@kullanim_durumu", "BOŞ");

                aracKiralama.ekle_sil_guncelle(kullanimKomut, kullanimSorgu);

                string kullanimDurumuIDsorgu = @"select * from kullanimdurumu where ""arac_plaka""= '" + txtPlaka.Text.ToString().ToUpper() + "'";
                string kullanimDurumuID = aracKiralama.bilgiGetir(kullanimDurumuIDsorgu, "id");

                string yakitDSorgu = @"select * from ""YakitDurumu"" where ""arac_plaka""= '" + txtPlaka.Text.ToString().ToUpper() + "'";
                string yakitID = aracKiralama.bilgiGetir(yakitDSorgu, "id");

                string guncelleSorgu = $"UPDATE arac SET kullanimdurumu = {kullanimDurumuID},yakitdurumu = {yakitID} WHERE plaka = '" + txtPlaka.Text.ToString().ToUpper() +"'";
                NpgsqlCommand guncelle = new NpgsqlCommand();
                aracKiralama.ekle_sil_guncelle(guncelle, guncelleSorgu);

                foreach (Control item in Controls)
                    if (item is TextBox)
                        item.Text = "";
                foreach (Control item in Controls)
                    if (item is ComboBox)
                        item.Text = "";

                TxtKayitBasari.Text = "KAYIT BAŞARILI";
                MessageBox.Show("Araç Ekledi!");
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            TxtKayitBasari.Text = "";
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKiraUcreti_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
