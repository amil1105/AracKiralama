namespace AracKiralama
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 119);
            this.panel1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "aracEkle.png");
            this.ımageList1.Images.SetKeyName(1, "carList.png");
            this.ımageList1.Images.SetKeyName(2, "deal.png");
            this.ımageList1.Images.SetKeyName(3, "exit.png");
            this.ımageList1.Images.SetKeyName(4, "listeleme.png");
            this.ımageList1.Images.SetKeyName(5, "musteriKayit.png");
            this.ımageList1.Images.SetKeyName(6, "müsteriListeleme.png");
            this.ımageList1.Images.SetKeyName(7, "sell.png");
            this.ımageList1.Images.SetKeyName(8, "deal2.png");
            this.ımageList1.Images.SetKeyName(9, "clientList2.png");
            this.ımageList1.Images.SetKeyName(10, "personel.png");
            this.ımageList1.Images.SetKeyName(11, "bills.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.anaSayfaFoto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageKey = "exit.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(816, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 97);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageKey = "sell.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(682, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 97);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "Satışlar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageKey = "carList.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(280, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 97);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Araç Yönetim";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageKey = "bills.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(548, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 97);
            this.button5.TabIndex = 2;
            this.button5.TabStop = false;
            this.button5.Text = "Faturalar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "deal2.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(414, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 97);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "Sözleşme";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "personel.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(146, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 97);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Personel Yönetim";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "clientList2.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 97);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Müşteri Yönetim";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}