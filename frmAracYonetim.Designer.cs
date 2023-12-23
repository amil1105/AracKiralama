namespace AracKiralama
{
    partial class frmAracYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracYonetim));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboYakit = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYakitmiktari = new System.Windows.Forms.TextBox();
            this.txtTuketim = new System.Windows.Forms.TextBox();
            this.labelDurumu = new System.Windows.Forms.Label();
            this.btnHasarKayit = new System.Windows.Forms.Button();
            this.btnBakimaGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 858);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraclar
            // 
            this.comboAraclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar",
            "Bakımda",
            "Hasarlı"});
            this.comboAraclar.Location = new System.Drawing.Point(390, 55);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(198, 24);
            this.comboAraclar.TabIndex = 1;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "update.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "carAdd.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 48);
            this.label9.TabIndex = 12;
            this.label9.Text = "ARAÇ LİSTELEME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRenk);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSeri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKiraUcreti);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 249);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Kira Ücreti";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(84, 145);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(224, 22);
            this.txtRenk.TabIndex = 27;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(84, 33);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(224, 22);
            this.txtPlaka.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "KM";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(84, 61);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(224, 22);
            this.txtMarka.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Renk";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(84, 89);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(224, 22);
            this.txtSeri.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Yıl";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(84, 117);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(224, 22);
            this.txtYil.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Seri";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(84, 173);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(224, 22);
            this.txtKM.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Marka";
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(84, 201);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(224, 22);
            this.txtKiraUcreti.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Plaka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Yakıt";
            // 
            // ComboYakit
            // 
            this.ComboYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboYakit.FormattingEnabled = true;
            this.ComboYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Hibrit",
            "Elektrik",
            "Benzin + LPG"});
            this.ComboYakit.Location = new System.Drawing.Point(84, 21);
            this.ComboYakit.Name = "ComboYakit";
            this.ComboYakit.Size = new System.Drawing.Size(224, 24);
            this.ComboYakit.TabIndex = 31;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "carAdd.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(12, 696);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(260, 66);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "delete.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(12, 621);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 66);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "update.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(145, 621);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 66);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "cancel.png";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(12, 840);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(260, 66);
            this.btnIptal.TabIndex = 42;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtYakitmiktari);
            this.groupBox2.Controls.Add(this.txtTuketim);
            this.groupBox2.Controls.Add(this.ComboYakit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 132);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yakıt Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Depodaki Yakıt miktarı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Tüketim l/100 km";
            // 
            // txtYakitmiktari
            // 
            this.txtYakitmiktari.Location = new System.Drawing.Point(177, 84);
            this.txtYakitmiktari.Name = "txtYakitmiktari";
            this.txtYakitmiktari.Size = new System.Drawing.Size(131, 22);
            this.txtYakitmiktari.TabIndex = 38;
            // 
            // txtTuketim
            // 
            this.txtTuketim.Location = new System.Drawing.Point(177, 56);
            this.txtTuketim.Name = "txtTuketim";
            this.txtTuketim.Size = new System.Drawing.Size(131, 22);
            this.txtTuketim.TabIndex = 39;
            // 
            // labelDurumu
            // 
            this.labelDurumu.AutoSize = true;
            this.labelDurumu.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurumu.Location = new System.Drawing.Point(5, 495);
            this.labelDurumu.Name = "labelDurumu";
            this.labelDurumu.Size = new System.Drawing.Size(129, 40);
            this.labelDurumu.TabIndex = 45;
            this.labelDurumu.Text = "Durumu:";
            // 
            // btnHasarKayit
            // 
            this.btnHasarKayit.BackColor = System.Drawing.Color.White;
            this.btnHasarKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHasarKayit.ImageKey = "update.png";
            this.btnHasarKayit.Location = new System.Drawing.Point(145, 768);
            this.btnHasarKayit.Name = "btnHasarKayit";
            this.btnHasarKayit.Size = new System.Drawing.Size(127, 66);
            this.btnHasarKayit.TabIndex = 40;
            this.btnHasarKayit.Text = "Hasar Kaydı Yap";
            this.btnHasarKayit.UseVisualStyleBackColor = false;
            this.btnHasarKayit.Visible = false;
            this.btnHasarKayit.Click += new System.EventHandler(this.btnHasarKayit_Click);
            // 
            // btnBakimaGonder
            // 
            this.btnBakimaGonder.BackColor = System.Drawing.Color.White;
            this.btnBakimaGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBakimaGonder.ImageKey = "delete.png";
            this.btnBakimaGonder.Location = new System.Drawing.Point(12, 768);
            this.btnBakimaGonder.Name = "btnBakimaGonder";
            this.btnBakimaGonder.Size = new System.Drawing.Size(127, 66);
            this.btnBakimaGonder.TabIndex = 43;
            this.btnBakimaGonder.Text = "Bakım Durumu";
            this.btnBakimaGonder.UseVisualStyleBackColor = false;
            this.btnBakimaGonder.Visible = false;
            this.btnBakimaGonder.Click += new System.EventHandler(this.btnBakimaGonder_Click);
            // 
            // frmAracYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.labelDurumu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBakimaGonder);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnHasarKayit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1918, 1000);
            this.Name = "frmAracYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Araç Listeleme Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboYakit;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtYakitmiktari;
        private System.Windows.Forms.TextBox txtTuketim;
        private System.Windows.Forms.Label labelDurumu;
        private System.Windows.Forms.Button btnHasarKayit;
        private System.Windows.Forms.Button btnBakimaGonder;
        public System.Windows.Forms.TextBox txtRenk;
        public System.Windows.Forms.TextBox txtPlaka;
        public System.Windows.Forms.TextBox txtMarka;
        public System.Windows.Forms.TextBox txtSeri;
        public System.Windows.Forms.TextBox txtYil;
        public System.Windows.Forms.TextBox txtKM;
        public System.Windows.Forms.TextBox txtKiraUcreti;
    }
}