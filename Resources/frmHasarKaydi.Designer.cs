namespace AracKiralama.Resources
{
    partial class frmHasarKaydi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHasarKaydi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHasarTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtHasarUcreti = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTCara = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtDogumT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.checkBoxKullanim = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 577);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtHasarTarihi
            // 
            this.txtHasarTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHasarTarihi.Location = new System.Drawing.Point(100, 59);
            this.txtHasarTarihi.Name = "txtHasarTarihi";
            this.txtHasarTarihi.Size = new System.Drawing.Size(208, 22);
            this.txtHasarTarihi.TabIndex = 56;
            this.txtHasarTarihi.TabStop = false;
            // 
            // txtHasarUcreti
            // 
            this.txtHasarUcreti.Location = new System.Drawing.Point(100, 87);
            this.txtHasarUcreti.Name = "txtHasarUcreti";
            this.txtHasarUcreti.Size = new System.Drawing.Size(208, 22);
            this.txtHasarUcreti.TabIndex = 27;
            this.txtHasarUcreti.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTCara);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtHasarTarihi);
            this.groupBox2.Controls.Add(this.txtHasarUcreti);
            this.groupBox2.Location = new System.Drawing.Point(14, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 233);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasar";
            // 
            // txtTCara
            // 
            this.txtTCara.Location = new System.Drawing.Point(126, 28);
            this.txtTCara.Name = "txtTCara";
            this.txtTCara.Size = new System.Drawing.Size(182, 22);
            this.txtTCara.TabIndex = 66;
            this.txtTCara.TextChanged += new System.EventHandler(this.txtTCara_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Açıklama";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(7, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 16);
            this.label18.TabIndex = 65;
            this.label18.Text = "Yapan Kişi TC :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciklama.Location = new System.Drawing.Point(100, 115);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(208, 104);
            this.txtAciklama.TabIndex = 56;
            this.txtAciklama.TabStop = false;
            this.txtAciklama.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Hasar Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Hasar Tarihi";
            // 
            // txtRenk
            // 
            this.txtRenk.Enabled = false;
            this.txtRenk.Location = new System.Drawing.Point(84, 145);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(224, 22);
            this.txtRenk.TabIndex = 27;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Enabled = false;
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
            this.txtMarka.Enabled = false;
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
            this.txtSeri.Enabled = false;
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
            this.txtYil.Enabled = false;
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
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(22, 600);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(260, 66);
            this.btnEkle.TabIndex = 64;
            this.btnEkle.Text = "Hasar Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKM
            // 
            this.txtKM.Enabled = false;
            this.txtKM.Location = new System.Drawing.Point(84, 173);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(224, 22);
            this.txtKM.TabIndex = 28;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 215);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Plaka";
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
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 48);
            this.label9.TabIndex = 58;
            this.label9.Text = "HASAR SAYFASI";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "cancel.png";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(24, 672);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(260, 66);
            this.btnIptal.TabIndex = 61;
            this.btnIptal.Text = "Geri";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "update.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(155, 529);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 66);
            this.btnGuncelle.TabIndex = 60;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "delete.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(22, 529);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 66);
            this.btnSil.TabIndex = 62;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTc);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtE_No);
            this.groupBox3.Controls.Add(this.txtDogumT);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtAdres);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtAdsoyad);
            this.groupBox3.Location = new System.Drawing.Point(1136, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 230);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yapan Kişi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Doğum T.\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 50;
            this.label17.Text = "Ehliyet No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "E-mail";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(99, 109);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Adres";
            // 
            // txtTc
            // 
            this.txtTc.Enabled = false;
            this.txtTc.Location = new System.Drawing.Point(99, 26);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 22);
            this.txtTc.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "Telefon";
            // 
            // txtE_No
            // 
            this.txtE_No.Enabled = false;
            this.txtE_No.Location = new System.Drawing.Point(99, 54);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(200, 22);
            this.txtE_No.TabIndex = 41;
            // 
            // txtDogumT
            // 
            this.txtDogumT.Enabled = false;
            this.txtDogumT.Location = new System.Drawing.Point(99, 193);
            this.txtDogumT.Name = "txtDogumT";
            this.txtDogumT.Size = new System.Drawing.Size(200, 22);
            this.txtDogumT.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(99, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "Ad Soyad";
            // 
            // txtAdres
            // 
            this.txtAdres.Enabled = false;
            this.txtAdres.Location = new System.Drawing.Point(99, 137);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 22);
            this.txtAdres.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "TC";
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Enabled = false;
            this.txtAdsoyad.Location = new System.Drawing.Point(99, 81);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(200, 22);
            this.txtAdsoyad.TabIndex = 44;
            // 
            // checkBoxKullanim
            // 
            this.checkBoxKullanim.AutoSize = true;
            this.checkBoxKullanim.Location = new System.Drawing.Point(344, 63);
            this.checkBoxKullanim.Name = "checkBoxKullanim";
            this.checkBoxKullanim.Size = new System.Drawing.Size(170, 20);
            this.checkBoxKullanim.TabIndex = 65;
            this.checkBoxKullanim.Text = "Araç Kullanıma Aktif mi?";
            this.checkBoxKullanim.UseVisualStyleBackColor = true;
            this.checkBoxKullanim.CheckedChanged += new System.EventHandler(this.checkBoxKullanim_CheckedChanged);
            // 
            // frmHasarKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1468, 750);
            this.Controls.Add(this.checkBoxKullanim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Name = "frmHasarKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasar Kayıt";
            this.Load += new System.EventHandler(this.frmHasarKaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txtHasarTarihi;
        private System.Windows.Forms.TextBox txtHasarUcreti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TextBox txtTCara;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtE_No;
        private System.Windows.Forms.TextBox txtDogumT;
        private System.Windows.Forms.CheckBox checkBoxKullanim;
    }
}