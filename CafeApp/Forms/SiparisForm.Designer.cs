﻿namespace CafeApp.Forms
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMasaNolar = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnSiparisİptal = new System.Windows.Forms.Button();
            this.btnAdisyonSil = new System.Windows.Forms.Button();
            this.btnAdisyonYaz = new System.Windows.Forms.Button();
            this.btnMasalaraDon = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(68, 17);
            this.cmbUrunler.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(277, 28);
            this.cmbUrunler.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(398, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisEkle.Location = new System.Drawing.Point(564, 14);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(253, 33);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(536, 548);
            this.dataGridView1.TabIndex = 4;
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
            this.panel1.Location = new System.Drawing.Point(554, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0);
            this.panel1.Size = new System.Drawing.Size(272, 200);
            this.panel1.TabIndex = 18;
            this.panel1.TabStop = false;
            this.panel1.Text = "Masa İşlemleri";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.Gold;
            this.lblMasaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMasaNo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.Location = new System.Drawing.Point(7, 23);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(138, 120);
            this.lblMasaNo.TabIndex = 3;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Masa No:";
            // 
            // cmbMasaNolar
            // 
            this.cmbMasaNolar.FormattingEnabled = true;
            this.cmbMasaNolar.Location = new System.Drawing.Point(152, 45);
            this.cmbMasaNolar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbMasaNolar.Name = "cmbMasaNolar";
            this.cmbMasaNolar.Size = new System.Drawing.Size(111, 25);
            this.cmbMasaNolar.TabIndex = 12;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.BackColor = System.Drawing.Color.Turquoise;
            this.btnMasaTasi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasaTasi.Location = new System.Drawing.Point(152, 84);
            this.btnMasaTasi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(114, 59);
            this.btnMasaTasi.TabIndex = 14;
            this.btnMasaTasi.Text = "Masa Taşı";
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeTutari.Location = new System.Drawing.Point(148, 156);
            this.lblOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(60, 23);
            this.lblOdemeTutari.TabIndex = 5;
            this.lblOdemeTutari.Text = "10.00₺";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOdemeAl.Location = new System.Drawing.Point(554, 267);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(145, 88);
            this.btnOdemeAl.TabIndex = 10;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnSiparisİptal
            // 
            this.btnSiparisİptal.BackColor = System.Drawing.Color.Tomato;
            this.btnSiparisİptal.Location = new System.Drawing.Point(706, 267);
            this.btnSiparisİptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisİptal.Name = "btnSiparisİptal";
            this.btnSiparisİptal.Size = new System.Drawing.Size(120, 88);
            this.btnSiparisİptal.TabIndex = 9;
            this.btnSiparisİptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisİptal.UseVisualStyleBackColor = false;
            // 
            // btnAdisyonSil
            // 
            this.btnAdisyonSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdisyonSil.Location = new System.Drawing.Point(692, 440);
            this.btnAdisyonSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdisyonSil.Name = "btnAdisyonSil";
            this.btnAdisyonSil.Size = new System.Drawing.Size(134, 80);
            this.btnAdisyonSil.TabIndex = 9;
            this.btnAdisyonSil.Text = "ADİSYONU SİL";
            this.btnAdisyonSil.UseVisualStyleBackColor = false;
            // 
            // btnAdisyonYaz
            // 
            this.btnAdisyonYaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdisyonYaz.Location = new System.Drawing.Point(554, 440);
            this.btnAdisyonYaz.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdisyonYaz.Name = "btnAdisyonYaz";
            this.btnAdisyonYaz.Size = new System.Drawing.Size(132, 80);
            this.btnAdisyonYaz.TabIndex = 15;
            this.btnAdisyonYaz.Text = "ADİSYON YAZDIR";
            this.btnAdisyonYaz.UseVisualStyleBackColor = false;
            // 
            // btnMasalaraDon
            // 
            this.btnMasalaraDon.BackColor = System.Drawing.Color.Orange;
            this.btnMasalaraDon.Location = new System.Drawing.Point(554, 526);
            this.btnMasalaraDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasalaraDon.Name = "btnMasalaraDon";
            this.btnMasalaraDon.Size = new System.Drawing.Size(272, 82);
            this.btnMasalaraDon.TabIndex = 11;
            this.btnMasalaraDon.Text = "MASA EKRANINA DÖN";
            this.btnMasalaraDon.UseVisualStyleBackColor = false;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRezervasyon.Location = new System.Drawing.Point(554, 361);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(272, 73);
            this.btnRezervasyon.TabIndex = 20;
            this.btnRezervasyon.Text = "MASA REZERVASYON";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 620);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMasalaraDon);
            this.Controls.Add(this.btnAdisyonYaz);
            this.Controls.Add(this.btnAdisyonSil);
            this.Controls.Add(this.btnSiparisİptal);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisForm";
            this.Text = "Sipariş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}