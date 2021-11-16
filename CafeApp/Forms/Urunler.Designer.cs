namespace CafeApp.Forms
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.nmrBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.lblUrunStok = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.lblUunFotografi = new System.Windows.Forms.Label();
            this.pbUrunResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(181, 9);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(101, 20);
            this.lblBirimFiyat.TabIndex = 0;
            this.lblBirimFiyat.Text = "Birim Fiyatı(₺)";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(11, 32);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(143, 27);
            this.txtUrunAd.TabIndex = 1;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(11, 9);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(67, 20);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(761, 132);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 48);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUrunEkle.ForeColor = System.Drawing.Color.Black;
            this.btnUrunEkle.Location = new System.Drawing.Point(763, 24);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(109, 48);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowDrop = true;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(11, 267);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 29;
            this.dgvUrunler.Size = new System.Drawing.Size(954, 268);
            this.dgvUrunler.TabIndex = 3;
            // 
            // nmrBirimFiyat
            // 
            this.nmrBirimFiyat.Location = new System.Drawing.Point(181, 33);
            this.nmrBirimFiyat.Name = "nmrBirimFiyat";
            this.nmrBirimFiyat.Size = new System.Drawing.Size(150, 27);
            this.nmrBirimFiyat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Urun Aciklamasi";
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(13, 105);
            this.txtUrunAciklamasi.Multiline = true;
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(318, 139);
            this.txtUrunAciklamasi.TabIndex = 6;
            // 
            // lblUrunStok
            // 
            this.lblUrunStok.AutoSize = true;
            this.lblUrunStok.Location = new System.Drawing.Point(353, 12);
            this.lblUrunStok.Name = "lblUrunStok";
            this.lblUrunStok.Size = new System.Drawing.Size(73, 20);
            this.lblUrunStok.TabIndex = 7;
            this.lblUrunStok.Text = "Ürün Stok";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(353, 35);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(310, 27);
            this.txtUrunStok.TabIndex = 8;
            // 
            // lblUunFotografi
            // 
            this.lblUunFotografi.AutoSize = true;
            this.lblUunFotografi.Location = new System.Drawing.Point(353, 82);
            this.lblUunFotografi.Name = "lblUunFotografi";
            this.lblUunFotografi.Size = new System.Drawing.Size(90, 20);
            this.lblUunFotografi.TabIndex = 9;
            this.lblUunFotografi.Text = "Ürün Görseli";
            // 
            // pbUrunResim
            // 
            this.pbUrunResim.Location = new System.Drawing.Point(353, 106);
            this.pbUrunResim.Name = "pbUrunResim";
            this.pbUrunResim.Size = new System.Drawing.Size(310, 138);
            this.pbUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrunResim.TabIndex = 10;
            this.pbUrunResim.TabStop = false;
            this.pbUrunResim.Click += new System.EventHandler(this.pbUrunResim_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 547);
            this.Controls.Add(this.pbUrunResim);
            this.Controls.Add(this.lblUunFotografi);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.lblUrunStok);
            this.Controls.Add(this.txtUrunAciklamasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrBirimFiyat);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblBirimFiyat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urunler";
            this.Text = "Menu Olusturucu";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.NumericUpDown nmrBirimFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAciklamasi;
        private System.Windows.Forms.Label lblUrunStok;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label lblUunFotografi;
        private System.Windows.Forms.PictureBox pbUrunResim;
    }
}