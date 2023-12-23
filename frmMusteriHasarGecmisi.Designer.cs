namespace AracKiralama
{
    partial class frmMusteriHasarGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriHasarGecmisi));
            this.btnIptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTCara = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "cancel.png";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(538, 662);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(260, 66);
            this.btnIptal.TabIndex = 71;
            this.btnIptal.Text = "Geri";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 577);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(530, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 48);
            this.label9.TabIndex = 67;
            this.label9.Text = "HASAR GECMİŞİ";
            // 
            // txtTCara
            // 
            this.txtTCara.Enabled = false;
            this.txtTCara.Location = new System.Drawing.Point(133, 51);
            this.txtTCara.Name = "txtTCara";
            this.txtTCara.Size = new System.Drawing.Size(182, 22);
            this.txtTCara.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(14, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 16);
            this.label18.TabIndex = 74;
            this.label18.Text = "Yapan Kişi TC :";
            // 
            // frmMusteriHasarGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(811, 733);
            this.Controls.Add(this.txtTCara);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Name = "frmMusteriHasarGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasar Geçmişi";
            this.Load += new System.EventHandler(this.frmMusteriHasarGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTCara;
        private System.Windows.Forms.Label label18;
    }
}