
namespace Nays
{
    partial class frmAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.txbTCGiris = new System.Windows.Forms.TextBox();
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.btnSayi4 = new System.Windows.Forms.Button();
            this.btnSayi6 = new System.Windows.Forms.Button();
            this.btnSayi7 = new System.Windows.Forms.Button();
            this.btnSayi8 = new System.Windows.Forms.Button();
            this.btnSayi9 = new System.Windows.Forms.Button();
            this.btnSayi5 = new System.Windows.Forms.Button();
            this.btnSayi0 = new System.Windows.Forms.Button();
            this.pnlSayiGiris = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pnlSayiGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAciklama.Location = new System.Drawing.Point(34, 24);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(457, 25);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "TC Kimlik Numarasini  Bulma Oyununa Hosgeldiniz";
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(158, 265);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(218, 58);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Baslamak Icin Tiklayiniz";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // txbTCGiris
            // 
            this.txbTCGiris.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbTCGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbTCGiris.Location = new System.Drawing.Point(158, 99);
            this.txbTCGiris.MaxLength = 9;
            this.txbTCGiris.Name = "txbTCGiris";
            this.txbTCGiris.ReadOnly = true;
            this.txbTCGiris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbTCGiris.Size = new System.Drawing.Size(218, 26);
            this.txbTCGiris.TabIndex = 2;
            this.txbTCGiris.Visible = false;
            this.txbTCGiris.TextChanged += new System.EventHandler(this.txbTCGiris_TextChanged);
            // 
            // btnSayi1
            // 
            this.btnSayi1.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi1.Location = new System.Drawing.Point(19, 12);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(36, 41);
            this.btnSayi1.TabIndex = 3;
            this.btnSayi1.Text = "1";
            this.btnSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi1.UseVisualStyleBackColor = false;
            this.btnSayi1.Click += new System.EventHandler(this.btnSayi1_Click);
            // 
            // btnSayi2
            // 
            this.btnSayi2.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi2.Location = new System.Drawing.Point(56, 12);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(36, 41);
            this.btnSayi2.TabIndex = 4;
            this.btnSayi2.Text = "2";
            this.btnSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi2.UseVisualStyleBackColor = false;
            this.btnSayi2.Click += new System.EventHandler(this.btnSayi2_Click);
            // 
            // btnSayi3
            // 
            this.btnSayi3.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi3.Location = new System.Drawing.Point(93, 12);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(36, 41);
            this.btnSayi3.TabIndex = 5;
            this.btnSayi3.Text = "3";
            this.btnSayi3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi3.UseVisualStyleBackColor = false;
            this.btnSayi3.Click += new System.EventHandler(this.btnSayi3_Click);
            // 
            // btnSayi4
            // 
            this.btnSayi4.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi4.Location = new System.Drawing.Point(130, 12);
            this.btnSayi4.Name = "btnSayi4";
            this.btnSayi4.Size = new System.Drawing.Size(36, 41);
            this.btnSayi4.TabIndex = 6;
            this.btnSayi4.Text = "4";
            this.btnSayi4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi4.UseVisualStyleBackColor = false;
            this.btnSayi4.Click += new System.EventHandler(this.btnSayi4_Click);
            // 
            // btnSayi6
            // 
            this.btnSayi6.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi6.Location = new System.Drawing.Point(19, 54);
            this.btnSayi6.Name = "btnSayi6";
            this.btnSayi6.Size = new System.Drawing.Size(36, 41);
            this.btnSayi6.TabIndex = 7;
            this.btnSayi6.Text = "6";
            this.btnSayi6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi6.UseVisualStyleBackColor = false;
            this.btnSayi6.Click += new System.EventHandler(this.btnSayi6_Click);
            // 
            // btnSayi7
            // 
            this.btnSayi7.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi7.Location = new System.Drawing.Point(56, 54);
            this.btnSayi7.Name = "btnSayi7";
            this.btnSayi7.Size = new System.Drawing.Size(36, 41);
            this.btnSayi7.TabIndex = 8;
            this.btnSayi7.Text = "7";
            this.btnSayi7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi7.UseVisualStyleBackColor = false;
            this.btnSayi7.Click += new System.EventHandler(this.btnSayi7_Click);
            // 
            // btnSayi8
            // 
            this.btnSayi8.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi8.Location = new System.Drawing.Point(93, 54);
            this.btnSayi8.Name = "btnSayi8";
            this.btnSayi8.Size = new System.Drawing.Size(36, 41);
            this.btnSayi8.TabIndex = 9;
            this.btnSayi8.Text = "8";
            this.btnSayi8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi8.UseVisualStyleBackColor = false;
            this.btnSayi8.Click += new System.EventHandler(this.btnSayi8_Click);
            // 
            // btnSayi9
            // 
            this.btnSayi9.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi9.Location = new System.Drawing.Point(130, 54);
            this.btnSayi9.Name = "btnSayi9";
            this.btnSayi9.Size = new System.Drawing.Size(36, 41);
            this.btnSayi9.TabIndex = 10;
            this.btnSayi9.Text = "9";
            this.btnSayi9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi9.UseVisualStyleBackColor = false;
            this.btnSayi9.Click += new System.EventHandler(this.btnSayi9_Click);
            // 
            // btnSayi5
            // 
            this.btnSayi5.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi5.Location = new System.Drawing.Point(167, 12);
            this.btnSayi5.Name = "btnSayi5";
            this.btnSayi5.Size = new System.Drawing.Size(36, 41);
            this.btnSayi5.TabIndex = 11;
            this.btnSayi5.Text = "5";
            this.btnSayi5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi5.UseVisualStyleBackColor = false;
            this.btnSayi5.Click += new System.EventHandler(this.btnSayi5_Click);
            // 
            // btnSayi0
            // 
            this.btnSayi0.BackColor = System.Drawing.Color.MintCream;
            this.btnSayi0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi0.Location = new System.Drawing.Point(167, 54);
            this.btnSayi0.Name = "btnSayi0";
            this.btnSayi0.Size = new System.Drawing.Size(36, 41);
            this.btnSayi0.TabIndex = 12;
            this.btnSayi0.Text = "0";
            this.btnSayi0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayi0.UseVisualStyleBackColor = false;
            this.btnSayi0.Click += new System.EventHandler(this.btnSayi0_Click);
            // 
            // pnlSayiGiris
            // 
            this.pnlSayiGiris.Controls.Add(this.btnSayi5);
            this.pnlSayiGiris.Controls.Add(this.btnSayi0);
            this.pnlSayiGiris.Controls.Add(this.btnSayi3);
            this.pnlSayiGiris.Controls.Add(this.btnSayi9);
            this.pnlSayiGiris.Controls.Add(this.btnSayi2);
            this.pnlSayiGiris.Controls.Add(this.btnSayi4);
            this.pnlSayiGiris.Controls.Add(this.btnSayi8);
            this.pnlSayiGiris.Controls.Add(this.btnSayi1);
            this.pnlSayiGiris.Controls.Add(this.btnSayi6);
            this.pnlSayiGiris.Controls.Add(this.btnSayi7);
            this.pnlSayiGiris.Location = new System.Drawing.Point(158, 140);
            this.pnlSayiGiris.Name = "pnlSayiGiris";
            this.pnlSayiGiris.Size = new System.Drawing.Size(218, 110);
            this.pnlSayiGiris.TabIndex = 13;
            this.pnlSayiGiris.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTemizle.Enabled = false;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(177, 256);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 58);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Visible = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.GhostWhite;
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(278, 256);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(83, 58);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Visible = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(524, 367);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txbTCGiris);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.pnlSayiGiris);
            this.MaximizeBox = false;
            this.Name = "frmAna";
            this.ShowIcon = false;
            this.Text = "Nays";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.pnlSayiGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox txbTCGiris;
        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button btnSayi4;
        private System.Windows.Forms.Button btnSayi6;
        private System.Windows.Forms.Button btnSayi7;
        private System.Windows.Forms.Button btnSayi8;
        private System.Windows.Forms.Button btnSayi9;
        private System.Windows.Forms.Button btnSayi5;
        private System.Windows.Forms.Button btnSayi0;
        private System.Windows.Forms.Panel pnlSayiGiris;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHesapla;
    }
}

