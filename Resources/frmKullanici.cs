using AracKiralama;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmKullanici : Form
    {
       
        public frmKullanici()
        {
            InitializeComponent();

        }
        public class Kullanici
        {
            public static long KullaniciTC = 0;
            public static string Yetki = "";
            public static bool durum = false;
            



            public static NpgsqlDataReader KullaniciGiris(TextBox Adi, TextBox Sifre)
            {
                AracKiralama vt = new AracKiralama();

                vt.baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from kullanici where kullanici_tc='" + long.Parse(Adi.Text) + "' and sifre='" + Sifre.Text + "'", vt.baglanti);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    durum = true;
                    KullaniciTC = long.Parse(dr["kullanici_tc"].ToString());
                    Yetki = dr["yetki"].ToString();
                }
                else
                {
                    durum = false;
                }
                vt.baglanti.Close();
                return dr;
            }
        }
       




        private void textBoxKadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;

            //if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            //{
            //    e.Handled = false;
            //}
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    e.Handled = true;
            //    btnGiris.PerformClick();
            //}
        }

        

        private void textBoxKSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && e.KeyChar == '\'' || e.KeyChar == ' ')
            //{
            //    e.Handled = true;
            //}
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    e.Handled = true;
            //    btnGiris.PerformClick();
            //}
        }

        private void frmKullanici_Load_1(object sender, EventArgs e)
        {

        }

        private  void btnGiris_Click_1(object sender, EventArgs e)
        {
            Kullanici.KullaniciGiris(textBoxKadi, textBoxKSifre);

           
            if (Kullanici.durum == true)
            {
                this.Hide();
                frmAnaSayfa frm = new frmAnaSayfa();
                frm.ShowDialog();

            }
            else if (Kullanici.durum == false)
            {
                MessageBox.Show("Giriş Yapılmadı, Kullanıcı Adı veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
