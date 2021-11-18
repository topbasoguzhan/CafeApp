namespace CafeApp.Forms
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.cmbMasaNolar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnSiparisİptal = new System.Windows.Forms.Button();
            this.btnAdisyonSil = new System.Windows.Forms.Button();
            this.btnAdisyonYaz = new System.Windows.Forms.Button();
            this.btnMasalaraDon = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(307, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(60, 13);
            this.cmbUrunler.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(243, 23);
            this.cmbUrunler.TabIndex = 6;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisEkle.Location = new System.Drawing.Point(494, 10);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(221, 25);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(10, 45);
            this.dgvSiparisler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 29;
            this.dgvSiparisler.Size = new System.Drawing.Size(469, 411);
            this.dgvSiparisler.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOdemeTutari);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnMasaTasi);
            this.panel1.Controls.Add(this.cmbMasaNolar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMasaNo);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(485, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0);
            this.panel1.Size = new System.Drawing.Size(238, 150);
            this.panel1.TabIndex = 18;
            this.panel1.TabStop = false;
            this.panel1.Text = "Masa İşlemleri";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeTutari.Location = new System.Drawing.Point(130, 117);
            this.lblOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(52, 18);
            this.lblOdemeTutari.TabIndex = 5;
            this.lblOdemeTutari.Text = "10.00₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.BackColor = System.Drawing.Color.Turquoise;
            this.btnMasaTasi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasaTasi.Location = new System.Drawing.Point(133, 63);
            this.btnMasaTasi.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(100, 44);
            this.btnMasaTasi.TabIndex = 14;
            this.btnMasaTasi.Text = "Masa Taşı";
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // cmbMasaNolar
            // 
            this.cmbMasaNolar.FormattingEnabled = true;
            this.cmbMasaNolar.Location = new System.Drawing.Point(133, 34);
            this.cmbMasaNolar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cmbMasaNolar.Name = "cmbMasaNolar";
            this.cmbMasaNolar.Size = new System.Drawing.Size(98, 23);
            this.cmbMasaNolar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(146, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Masa No:";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.Gold;
            this.lblMasaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMasaNo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.Location = new System.Drawing.Point(6, 17);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(121, 90);
            this.lblMasaNo.TabIndex = 3;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMasaNo.Click += new System.EventHandler(this.lblMasaNo_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOdemeAl.Location = new System.Drawing.Point(485, 200);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(127, 66);
            this.btnOdemeAl.TabIndex = 10;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnSiparisİptal
            // 
            this.btnSiparisİptal.BackColor = System.Drawing.Color.Tomato;
            this.btnSiparisİptal.Location = new System.Drawing.Point(618, 200);
            this.btnSiparisİptal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiparisİptal.Name = "btnSiparisİptal";
            this.btnSiparisİptal.Size = new System.Drawing.Size(105, 66);
            this.btnSiparisİptal.TabIndex = 9;
            this.btnSiparisİptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisİptal.UseVisualStyleBackColor = false;
            // 
            // btnAdisyonSil
            // 
            this.btnAdisyonSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdisyonSil.Location = new System.Drawing.Point(606, 330);
            this.btnAdisyonSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdisyonSil.Name = "btnAdisyonSil";
            this.btnAdisyonSil.Size = new System.Drawing.Size(117, 60);
            this.btnAdisyonSil.TabIndex = 9;
            this.btnAdisyonSil.Text = "ADİSYONU SİL";
            this.btnAdisyonSil.UseVisualStyleBackColor = false;
            // 
            // btnAdisyonYaz
            // 
            this.btnAdisyonYaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdisyonYaz.Location = new System.Drawing.Point(485, 330);
            this.btnAdisyonYaz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdisyonYaz.Name = "btnAdisyonYaz";
            this.btnAdisyonYaz.Size = new System.Drawing.Size(116, 60);
            this.btnAdisyonYaz.TabIndex = 15;
            this.btnAdisyonYaz.Text = "ADİSYON YAZDIR";
            this.btnAdisyonYaz.UseVisualStyleBackColor = false;
            // 
            // btnMasalaraDon
            // 
            this.btnMasalaraDon.BackColor = System.Drawing.Color.Orange;
            this.btnMasalaraDon.Location = new System.Drawing.Point(485, 394);
            this.btnMasalaraDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMasalaraDon.Name = "btnMasalaraDon";
            this.btnMasalaraDon.Size = new System.Drawing.Size(238, 62);
            this.btnMasalaraDon.TabIndex = 11;
            this.btnMasalaraDon.Text = "MASA EKRANINA DÖN";
            this.btnMasalaraDon.UseVisualStyleBackColor = false;
            this.btnMasalaraDon.Click += new System.EventHandler(this.btnMasalaraDon_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRezervasyon.Location = new System.Drawing.Point(485, 271);
            this.btnRezervasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(238, 55);
            this.btnRezervasyon.TabIndex = 20;
            this.btnRezervasyon.Text = "MASA REZERVASYON";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(348, 14);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(131, 23);
            this.nmrAdet.TabIndex = 21;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 465);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMasalaraDon);
            this.Controls.Add(this.btnAdisyonYaz);
            this.Controls.Add(this.btnAdisyonSil);
            this.Controls.Add(this.btnSiparisİptal);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisForm";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.ComboBox cmbMasaNolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnSiparisİptal;
        private System.Windows.Forms.Button btnAdisyonSil;
        private System.Windows.Forms.Button btnAdisyonYaz;
        private System.Windows.Forms.Button btnMasalaraDon;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.NumericUpDown nmrAdet;
    }
}