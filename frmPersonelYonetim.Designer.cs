namespace AracKiralama
{
    partial class frmPersonelYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelYonetim));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtE_yer = new System.Windows.Forms.ComboBox();
            this.dateTimeE_tarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTcArama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGorevi = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtSifreK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "update.png");
            this.ımageList1.Images.SetKeyName(3, "musteriEkle.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Verildiği Şehir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Alınma Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "Ehliyet No:";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Enabled = false;
            this.txtEhliyetNo.Location = new System.Drawing.Point(106, 33);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(200, 22);
            this.txtEhliyetNo.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtE_yer);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtEhliyetNo);
            this.groupBox2.Controls.Add(this.dateTimeE_tarih);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(4, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 149);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ehliyet";
            // 
            // txtE_yer
            // 
            this.txtE_yer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtE_yer.FormattingEnabled = true;
            this.txtE_yer.Location = new System.Drawing.Point(106, 89);
            this.txtE_yer.Name = "txtE_yer";
            this.txtE_yer.Size = new System.Drawing.Size(200, 24);
            this.txtE_yer.TabIndex = 40;
            // 
            // dateTimeE_tarih
            // 
            this.dateTimeE_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeE_tarih.Location = new System.Drawing.Point(106, 61);
            this.dateTimeE_tarih.Name = "dateTimeE_tarih";
            this.dateTimeE_tarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimeE_tarih.TabIndex = 47;
            // 
            // dateTimeDogumTarihi
            // 
            this.dateTimeDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDogumTarihi.Location = new System.Drawing.Point(106, 203);
            this.dateTimeDogumTarihi.Name = "dateTimeDogumTarihi";
            this.dateTimeDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDogumTarihi.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Doğum T.\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "E-mail";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(106, 119);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Adres";
            // 
            // txtTc
            // 
            this.txtTc.Enabled = false;
            this.txtTc.Location = new System.Drawing.Point(106, 63);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 22);
            this.txtTc.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 43);
            this.label9.TabIndex = 37;
            this.label9.Text = "PERSONEL LİSTELEME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ad Soyad";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(106, 147);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 22);
            this.txtAdres.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "TC";
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(106, 91);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(200, 22);
            this.txtAdsoyad.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(353, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "TC ARAMA :";
            // 
            // txtTcArama
            // 
            this.txtTcArama.Location = new System.Drawing.Point(460, 43);
            this.txtTcArama.Name = "txtTcArama";
            this.txtTcArama.Size = new System.Drawing.Size(200, 22);
            this.txtTcArama.TabIndex = 35;
            this.txtTcArama.TextChanged += new System.EventHandler(this.txtTcArama_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtGorevi);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.dateTimeDogumTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdsoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(4, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 307);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 61;
            this.label13.Text = "Maaş:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 60;
            this.label12.Text = "Gorevi:";
            // 
            // txtGorevi
            // 
            this.txtGorevi.Location = new System.Drawing.Point(106, 232);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Size = new System.Drawing.Size(200, 22);
            this.txtGorevi.TabIndex = 59;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(106, 260);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(200, 22);
            this.txtMaas.TabIndex = 57;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(333, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1571, 874);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "musteriEkle.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(14, 688);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(260, 66);
            this.btnEkle.TabIndex = 32;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "delete.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(14, 613);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 66);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "update.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(147, 613);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 66);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "cancel.png";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(14, 874);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(260, 66);
            this.btnIptal.TabIndex = 33;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // txtSifreK
            // 
            this.txtSifreK.Location = new System.Drawing.Point(110, 548);
            this.txtSifreK.Name = "txtSifreK";
            this.txtSifreK.Size = new System.Drawing.Size(200, 22);
            this.txtSifreK.TabIndex = 40;
            this.txtSifreK.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Şifre:";
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Location = new System.Drawing.Point(110, 576);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(105, 20);
            this.checkBoxSifre.TabIndex = 42;
            this.checkBoxSifre.Text = "şifreyi göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // frmPersonelYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1900, 953);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSifreK);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTcArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmPersonelYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonelYonetim_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeE_tarih;
        private System.Windows.Forms.DateTimePicker dateTimeDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTcArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGorevi;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.ComboBox txtE_yer;
        private System.Windows.Forms.TextBox txtSifreK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxSifre;
    }
}