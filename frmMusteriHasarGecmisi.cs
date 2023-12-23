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
    public partial class frmMusteriHasarGecmisi : Form
    {
        string TC ="";
        AracKiralama arac = new AracKiralama();
        public frmMusteriHasarGecmisi(string tc)
        {
            TC = tc;
          
            InitializeComponent();
        }

        void yenile()
        {
            txtTCara.Text = TC;
            string cumle = "select * from MusteriHasarGecmisi("+TC+")";
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr,cumle);



        }

        private void frmMusteriHasarGecmisi_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
