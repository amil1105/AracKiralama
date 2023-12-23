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
    public partial class frmMusteriKiralamaGecmisi : Form
    {
        string TC = "";
        AracKiralama arac = new AracKiralama();
        public frmMusteriKiralamaGecmisi(string tc)
        {
            TC = tc;
            InitializeComponent();
        }
        void yenile()
        {
           
            string cumle = "select * from MusteriKiralamaGecmisiBul(" + TC + ")";
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, cumle);



        }
        private void frmMusteriKiralamaGecmisi_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
