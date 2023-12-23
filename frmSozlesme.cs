using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmSozlesme : Form
    {
        public frmSozlesme()
        {
            InitializeComponent();
        }

        AracKiralama arac = new AracKiralama();
        public int idNumber = 1;
        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            BosAraclar();
            yenile();

            //string sorgu4 = "SELECT TOP 1 id FROM SatışTablo ORDER BY id DESC";

            //arac.IdArtir(labelid, sorgu4);
            // idNumber = int.Parse(labelid.Text);

            DateTime bugun = DateTime.Now;
            string BugunTarihi = bugun.ToLongDateString();
            LabelBugun.Text = BugunTarihi;



        }

        private void BosAraclar()
        {
            string sorgu2 = "SELECT arac.plaka,arac.marka,arac.seri,arac.renk,arac.km,arac.kiraucreti,arac.yil FROM arac JOIN kullanimdurumu ON kullanimdurumu.arac_plaka = arac.plaka WHERE kullanimdurumu.kullanim_durumu = 'BOŞ';";

            arac.BosAraclar(comboAraclar, sorgu2);
        }

        private void yenile()
        {
            string sorgu3 = @"select * from ""KiralamaSozlesmesi""";
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "MÜŞTERİ TC";
            dataGridView1.Columns[2].HeaderText = "EHLİYET NO";
            dataGridView1.Columns[3].HeaderText = "PLAKA";
            dataGridView1.Columns[4].HeaderText = "KİRA ŞEKLİ";
            dataGridView1.Columns[5].HeaderText = "GÜN";
            dataGridView1.Columns[6].HeaderText = "TUTAR";
            dataGridView1.Columns[7].HeaderText = "Ç TARİH";
            dataGridView1.Columns[8].HeaderText = "D TARİH";
            dataGridView1.Columns[9].HeaderText = "KİRA ÜCRETİ";
            string sorgu2 = @"select * from ""KiraSekliTablo""";

            arac.kiraTurleriniGetir(comboKiraSekli, sorgu2);


        }


        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from arac where plaka like '" + comboAraclar.SelectedItem + "'";
            arac.CombodanGetir(txtMarka, txtSeri, txtYil, txtRenk, txtKiraUcreti, sorgu2);
        }

        private void comboKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            double indirimYuzdesi = 0;

            comboAraclar_SelectedIndexChanged(sender, e);
            string sorgu2 = @"select * from ""KiraSekliTablo"" where adi like '" + comboKiraSekli.SelectedItem + "'";
            indirimYuzdesi = double.Parse(arac.bilgiGetir(sorgu2, "indirimYuzdesi"));
            indirimYuzdesi = 100 - indirimYuzdesi;

            if (txtKiraUcreti.Text != "")
                txtKiraUcreti.Text = (double.Parse(txtKiraUcreti.Text) * (indirimYuzdesi / 100)).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int gunfarki = gun.Days;
            txtGun.Text = gunfarki.ToString();
            txtTutar.Text = (gunfarki * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = @"insert into ""KiralamaSozlesmesi""(musteri_tc,ehliyetno,plaka,kirasekli,gun,tutar,ctarih,dtarih,kiraucreti) values(@musteri_tc,@ehliyetno,@plaka,@kirasekli,@gun,@tutar,@ctarih,@dtarih,@kiraucreti)";
            NpgsqlCommand komut2 = new NpgsqlCommand();
            komut2.Parameters.AddWithValue("@musteri_tc", long.Parse(txtTc.Text));
            komut2.Parameters.AddWithValue("@ehliyetno", long.Parse(txtE_No.Text));
            komut2.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", DateTime.Parse(dateCikis.Text));
            komut2.Parameters.AddWithValue("@dtarih", DateTime.Parse(dateDonus.Text));
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));

            arac.ekle_sil_guncelle(komut2, sorgu2);

            string kullanimDurumuIDsorgu = @"select * from kullanimdurumu where ""arac_plaka""= '" + comboAraclar.Text.ToString() + "'";
            string kullanimDurumuID = arac.bilgiGetir(kullanimDurumuIDsorgu, "id");

            string guncelleSorgu = $"UPDATE kullanimdurumu SET kullanim_durumu = \'DOLU\' WHERE id = '" + kullanimDurumuID + "'";
            NpgsqlCommand guncelle = new NpgsqlCommand();
            arac.ekle_sil_guncelle(guncelle, guncelleSorgu);



            comboAraclar.Items.Clear();
            BosAraclar();
            yenile();
            foreach (Control item in groupBox1.Controls)
                if (item is TextBox)
                    item.Text = "";
            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                    item.Text = "";
            comboAraclar.Items.Clear();
            comboKiraSekli.Items.Clear();
        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {



            string sorgu2 = @"select * from kisi where CAST(tc AS TEXT) like '" + txtTCara.Text + "%'";

            arac.TC_ara(txtTc, txtAdSoyad, txtTelefon, txtE_No, sorgu2);
            string sorgu3 = "select * from ehliyet where ehliyetno=" + long.Parse(txtE_No.Text.ToString()) + "";

            arac.Ehliyet_ara(txtTc, txtE_No, txt_E_yer, txt_E_Tarih, sorgu3);
            DateTime date = DateTime.Parse(txt_E_Tarih.Text);
            txt_E_Tarih.Text = date.ToShortDateString();



        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTCara.Text = satir.Cells[1].Value.ToString();
            comboAraclar.Text = satir.Cells[3].Value.ToString();
            comboKiraSekli.Text = satir.Cells[4].Value.ToString();
            txtKiraUcreti.Text = satir.Cells[9].Value.ToString();
            txtGun.Text = satir.Cells[5].Value.ToString();
            txtTutar.Text = satir.Cells[6].Value.ToString();
            dateCikis.Text = satir.Cells[7].Value.ToString();
            dateDonus.Text = satir.Cells[8].Value.ToString();

            string sorgu2 = "select *from arac where plaka like '" + satir.Cells[3].Value.ToString() + "'";
            txtMarka.Text = arac.bilgiGetir(sorgu2, "marka");
            txtRenk.Text = arac.bilgiGetir(sorgu2, "renk");
            txtSeri.Text = arac.bilgiGetir(sorgu2, "seri");
            txtYil.Text = arac.bilgiGetir(sorgu2, "yil");
          








        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = donus - bugun;
            int _gunfarki = gunfarki.Days;
            labelGunSayac.Text = "Kaç günü kaldı: " + _gunfarki;



            int ucretfarki;

            ucretfarki = _gunfarki * ucret;
            txtEkstra.Text = ucretfarki.ToString();


        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text != "")
            {
                string markaSorgu = "select * from arac where plaka= '" + comboAraclar.Text + "'";


                string marka = arac.bilgiGetir(markaSorgu, "marka");
                string seri = arac.bilgiGetir(markaSorgu, "seri");
                string yil = arac.bilgiGetir(markaSorgu, "yil");
                string renk = arac.bilgiGetir(markaSorgu, "renk");

                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
             
                DateTime cikis = DateTime.Parse(satir.Cells["ctarih"].Value.ToString());
                TimeSpan gun = cikis - bugun;
                int _gun = gun.Days;
                int toplamTutar = _gun * ucret;

               

                string sorgu5 = @"SELECT * from arac_teslim_et("+ satir.Cells["musteri_tc"].Value.ToString() + ",'"+ satir.Cells["plaka"].Value.ToString() + "')";
                NpgsqlCommand komut5 = new NpgsqlCommand();
                arac.ekle_sil_guncelle(komut5, sorgu5);

                string sorgu3 = @"insert into ""KiralamaGecmisi""(musteri_tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2) values(@musteri_tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2) RETURNING id";
                NpgsqlCommand komut2 = new NpgsqlCommand();

                komut2.Parameters.AddWithValue("@musteri_tc", long.Parse(satir.Cells["musteri_tc"].Value.ToString()));
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text.ToString());
                komut2.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", marka);
                komut2.Parameters.AddWithValue("@seri", seri);
                komut2.Parameters.AddWithValue("@yil", int.Parse(yil));
                komut2.Parameters.AddWithValue("@renk", renk);

                komut2.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
                komut2.Parameters.AddWithValue("@fiyat", ucret);
                komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@tarih1", DateTime.Parse(satir.Cells["ctarih"].Value.ToString()));
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Parse(satir.Cells["dtarih"].Value.ToString()));

                arac.ekle_sil_guncelle2(komut2, sorgu3);


                int lastInsertedId = Convert.ToInt32(komut2.ExecuteScalar());

                string faturaSorgu = @"INSERT INTO ""FaturaTablo"" (islem_tarihi, satis_id, tutar) VALUES (@islem_tarihi, @satis_id, @tutar)";
                NpgsqlCommand faturakomut = new NpgsqlCommand();
                faturakomut.Parameters.AddWithValue("@islem_tarihi", DateTime.Parse(satir.Cells["dtarih"].Value.ToString()));
                faturakomut.Parameters.AddWithValue("@satis_id", lastInsertedId);
                faturakomut.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
                arac.baglanti.Close();
                arac.ekle_sil_guncelle(faturakomut, faturaSorgu);



                MessageBox.Show("Araç Başarıyla teslim edildi", "Bilgi");
                yenile();
                foreach (Control item in groupBox1.Controls)
                    if (item is TextBox)
                        item.Text = "";
                foreach (Control item in groupBox2.Controls)
                    if (item is TextBox)
                        item.Text = "";
                comboAraclar.Items.Clear();
                comboKiraSekli.Items.Clear();
                labelGunSayac.Text = "";
                btnSil.Visible = false;
                txtEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Araç seçiniz.", "Uyarı");
            }

        }

        private void LabelBugun_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu1 = @"delete from ""KiralamaSozlesmesi"" where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
            NpgsqlCommand komut = new NpgsqlCommand();
            arac.ekle_sil_guncelle(komut, sorgu1);
            string sorgu3 = "update kullanimdurumu set kullanim_durumu='BOŞ' where arac_plaka= '" + comboAraclar.Text + "'";
            NpgsqlCommand komut3 = new NpgsqlCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);
            comboAraclar.Items.Clear();
            foreach (Control item in groupBox1.Controls)
                if (item is TextBox)
                    item.Text = "";
            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                    item.Text = "";
            comboAraclar.Items.Clear();
            comboKiraSekli.Items.Clear();
            BosAraclar();
            yenile();
            labelGunSayac.Text = "";
            btnSil.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCara_Click(object sender, EventArgs e)
        {
            if (txtTCara.Text == "")
            {
                txtTc.Text = ""; txtAdSoyad.Text = ""; txtTelefon.Text = ""; txtE_No.Text = ""; txt_E_yer.Text = "";
                txt_E_Tarih.Text = "";
            }
        }

        private void comboAraclar_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboAraclar_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
