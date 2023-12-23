namespace AracKiralama
{
    partial class frmMusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriEkle));
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtKayitBasari = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.dateTimeE_tarih = new System.Windows.Forms.DateTimePicker();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtE_yer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(85, 103);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 22);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(85, 187);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 22);
            this.txtAdres.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(85, 159);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(85, 131);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(200, 22);
            this.txtAdsoyad.TabIndex = 4;
            this.txtAdsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdsoyad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "musteriKayit.png");
            // 
            // TxtKayitBasari
            // 
            this.TxtKayitBasari.AutoSize = true;
            this.TxtKayitBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitBasari.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtKayitBasari.Location = new System.Drawing.Point(270, 357);
            this.TxtKayitBasari.Name = "TxtKayitBasari";
            this.TxtKayitBasari.Size = new System.Drawing.Size(0, 16);
            this.TxtKayitBasari.TabIndex = 13;
            this.TxtKayitBasari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 40);
            this.label9.TabIndex = 14;
            this.label9.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // dateTimeDogumTarihi
            // 
            this.dateTimeDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDogumTarihi.Location = new System.Drawing.Point(85, 244);
            this.dateTimeDogumTarihi.Name = "dateTimeDogumTarihi";
            this.dateTimeDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDogumTarihi.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Doğum T:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(382, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "EHLİYET BİLGİLERİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Verildiği Şehir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Alınma Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Ehliyet No:";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(440, 103);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(200, 22);
            this.txtEhliyetNo.TabIndex = 41;
            this.txtEhliyetNo.Text = " ";
            // 
            // dateTimeE_tarih
            // 
            this.dateTimeE_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeE_tarih.Location = new System.Drawing.Point(440, 131);
            this.dateTimeE_tarih.Name = "dateTimeE_tarih";
            this.dateTimeE_tarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimeE_tarih.TabIndex = 39;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImageIndex = 0;
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(428, 323);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 43);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(540, 323);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 43);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtE_yer
            // 
            this.txtE_yer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtE_yer.FormattingEnabled = true;
            this.txtE_yer.Location = new System.Drawing.Point(440, 159);
            this.txtE_yer.Name = "txtE_yer";
            this.txtE_yer.Size = new System.Drawing.Size(200, 24);
            this.txtE_yer.TabIndex = 47;
            // 
            // frmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(669, 378);
            this.Controls.Add(this.txtE_yer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEhliyetNo);
            this.Controls.Add(this.dateTimeE_tarih);
            this.Controls.Add(this.dateTimeDogumTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtKayitBasari);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(687, 425);
            this.MinimumSize = new System.Drawing.Size(687, 425);
            this.Name = "frmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label TxtKayitBasari;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.DateTimePicker dateTimeE_tarih;
        private System.Windows.Forms.ComboBox txtE_yer;
    }
}