using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NpgsqlTypes;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class frmSatis : Form
    {
        AracKiralama arac = new AracKiralama();
        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            string sorgu2 = @"select * from ""KiralamaGecmisi""";
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
            arac.satisHesapla(label1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
        }
        AracKiralama aracKiralama = new AracKiralama();
        public void yenile()
        {
            string cumle = @"select * from ""KiralamaGecmisi""";
            NpgsqlDataAdapter adtr2 = new NpgsqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, cumle);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu1 = @"delete from ""KiralamaGecmisi"" where id='" + satir.Cells["id"].Value.ToString() + "'";
            NpgsqlCommand komut = new NpgsqlCommand();
            arac.ekle_sil_guncelle(komut, sorgu1);
            yenile();
            arac.satisHesapla(label1);
            btnSil.Visible = false;

        }

       


       
    }
}
