namespace AracKiralama
{
    partial class frmAracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.ComboYakit = new System.Windows.Forms.ComboBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracIptal = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.TxtKayitBasari = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTuketim = new System.Windows.Forms.TextBox();
            this.txtYakitmiktari = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(171, 23);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(224, 22);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(171, 107);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(224, 22);
            this.txtYil.TabIndex = 0;
            this.txtYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYil_KeyPress);
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(171, 135);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(224, 22);
            this.txtRenk.TabIndex = 0;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(171, 163);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(224, 22);
            this.txtKM.TabIndex = 0;
            this.txtKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKM_KeyPress);
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
            this.ComboYakit.Location = new System.Drawing.Point(171, 191);
            this.ComboYakit.Name = "ComboYakit";
            this.ComboYakit.Size = new System.Drawing.Size(224, 24);
            this.ComboYakit.TabIndex = 1;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(171, 221);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(224, 22);
            this.txtKiraUcreti.TabIndex = 0;
            this.txtKiraUcreti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKiraUcreti_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Renk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kira Ücreti";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.BackColor = System.Drawing.Color.White;
            this.btnAracKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracKayit.ImageKey = "aracEkle.png";
            this.btnAracKayit.ImageList = this.ımageList1;
            this.btnAracKayit.Location = new System.Drawing.Point(590, 264);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(109, 48);
            this.btnAracKayit.TabIndex = 3;
            this.btnAracKayit.Text = "Kayıt";
            this.btnAracKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracKayit.UseVisualStyleBackColor = false;
            this.btnAracKayit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "aracEkle.png");
            this.ımageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // btnAracIptal
            // 
            this.btnAracIptal.BackColor = System.Drawing.Color.White;
            this.btnAracIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracIptal.ImageKey = "cancel.png";
            this.btnAracIptal.ImageList = this.ımageList1;
            this.btnAracIptal.Location = new System.Drawing.Point(475, 264);
            this.btnAracIptal.Name = "btnAracIptal";
            this.btnAracIptal.Size = new System.Drawing.Size(109, 48);
            this.btnAracIptal.TabIndex = 3;
            this.btnAracIptal.Text = "İptal";
            this.btnAracIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracIptal.UseVisualStyleBackColor = false;
            this.btnAracIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(171, 51);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(224, 22);
            this.txtMarka.TabIndex = 0;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(171, 79);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(224, 22);
            this.txtSeri.TabIndex = 0;
            // 
            // TxtKayitBasari
            // 
            this.TxtKayitBasari.AutoSize = true;
            this.TxtKayitBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitBasari.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtKayitBasari.Location = new System.Drawing.Point(265, 358);
            this.TxtKayitBasari.Name = "TxtKayitBasari";
            this.TxtKayitBasari.Size = new System.Drawing.Size(0, 16);
            this.TxtKayitBasari.TabIndex = 4;
            this.TxtKayitBasari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(520, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 48);
            this.label9.TabIndex = 13;
            this.label9.Text = "ARAÇ KAYIT";
            // 
            // txtTuketim
            // 
            this.txtTuketim.Location = new System.Drawing.Point(171, 249);
            this.txtTuketim.Name = "txtTuketim";
            this.txtTuketim.Size = new System.Drawing.Size(224, 22);
            this.txtTuketim.TabIndex = 0;
            this.txtTuketim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKiraUcreti_KeyPress);
            // 
            // txtYakitmiktari
            // 
            this.txtYakitmiktari.Location = new System.Drawing.Point(171, 277);
            this.txtYakitmiktari.Name = "txtYakitmiktari";
            this.txtYakitmiktari.Size = new System.Drawing.Size(224, 22);
            this.txtYakitmiktari.TabIndex = 0;
            this.txtYakitmiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKiraUcreti_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tüketim l/100 km";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Depodaki Yakıt miktarı";
            this.label11.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(732, 329);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtKayitBasari);
            this.Controls.Add(this.btnAracIptal);
            this.Controls.Add(this.btnAracKayit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboYakit);
            this.Controls.Add(this.txtYakitmiktari);
            this.Controls.Add(this.txtTuketim);
            this.Controls.Add(this.txtKiraUcreti);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtPlaka);
            this.MinimumSize = new System.Drawing.Size(416, 376);
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.Load += new System.EventHandler(this.frmAracKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.ComboBox ComboYakit;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAracIptal;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label TxtKayitBasari;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTuketim;
        private System.Windows.Forms.TextBox txtYakitmiktari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}