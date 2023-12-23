using AracKiralama.Resources;
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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            this.AcceptButton = null; this.CancelButton = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriYonetim listele = new frmMusteriYonetim();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAracKayit aracKayit = new frmAracKayit();
            aracKayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracYonetim aracListele = new frmAracYonetim();
            aracListele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSozlesme sozlesme = new frmSozlesme();
            sozlesme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPersonelYonetim per = new frmPersonelYonetim();
            per.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmFaturalar sozlesme = new frmFaturalar();
            sozlesme.ShowDialog();
        }
    }
}
