using System.Drawing;
using System.Windows.Forms;

namespace AracKiralama
{
    partial class frmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanici));
            this.textBoxKadi = new System.Windows.Forms.TextBox();
            this.textBoxKSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKadi
            // 
            this.textBoxKadi.Location = new System.Drawing.Point(15, 229);
            this.textBoxKadi.Name = "textBoxKadi";
            this.textBoxKadi.Size = new System.Drawing.Size(326, 22);
            this.textBoxKadi.TabIndex = 0;
            this.textBoxKadi.Text = "99517397000";
            this.textBoxKadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKadi_KeyPress);
            // 
            // textBoxKSifre
            // 
            this.textBoxKSifre.Location = new System.Drawing.Point(15, 290);
            this.textBoxKSifre.Name = "textBoxKSifre";
            this.textBoxKSifre.Size = new System.Drawing.Size(326, 22);
            this.textBoxKSifre.TabIndex = 0;
            this.textBoxKSifre.TabStop = false;
            this.textBoxKSifre.Text = "99517397000";
            this.textBoxKSifre.UseSystemPasswordChar = true;
            this.textBoxKSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKSifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(159)))));
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Location = new System.Drawing.Point(12, 378);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(325, 58);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseMnemonic = false;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // frmKullanici
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 454);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKSifre);
            this.Controls.Add(this.textBoxKadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.frmKullanici_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKadi;
        private TextBox textBoxKSifre;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnGiris;
    }
}