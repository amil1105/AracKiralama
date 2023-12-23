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
    public partial class frmFaturalar : Form
    {
        AracKiralama arac = new AracKiralama();
        string id = string.Empty;
        public frmFaturalar()
        {
            InitializeComponent();
            yenile();
        }
        void yenile()
        {
            string sorgu = @"select * from ""FaturaTablo""";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();

            dataGridView1.DataSource = arac.listele(da, sorgu);
        }

        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = @"update ""FaturaTablo"" set odeme_durumu=@odeme_durumu,odeme_tarihi = @odeme_tarihi where id=@id";
            NpgsqlCommand komut = new NpgsqlCommand();
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            komut.Parameters.AddWithValue("@odeme_tarihi", bugun);
            komut.Parameters.AddWithValue("@odeme_durumu", true);
            komut.Parameters.AddWithValue("@id", int.Parse(id));
            
            arac.ekle_sil_guncelle(komut, sorgu);
            yenile();
            btnOnayla.Visible = false;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            id = satir.Cells[0].Value.ToString();
            if (id != "")
            {

                btnOnayla.Visible = true;
            }

        }
    }
}
