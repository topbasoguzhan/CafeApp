﻿namespace CafeApp.Forms
{
    partial class Choice
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
                System.Console.WriteLine();
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
            this.cmbKatSayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKatTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuyeGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKatSayisi
            // 
            this.cmbKatSayisi.FormattingEnabled = true;
            this.cmbKatSayisi.Location = new System.Drawing.Point(182, 46);
            this.cmbKatSayisi.Name = "cmbKatSayisi";
            this.cmbKatSayisi.Size = new System.Drawing.Size(128, 28);
            this.cmbKatSayisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katı Seciniz:";
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(139, 23);
            this.cmbKat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(166, 28);
            this.cmbKat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(313, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "KatTipini Seciniz:";
            // 
            // cmbKatTip
            // 
            this.cmbKatTip.FormattingEnabled = true;
            this.cmbKatTip.Location = new System.Drawing.Point(505, 21);
            this.cmbKatTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKatTip.Name = "cmbKatTip";
            this.cmbKatTip.Size = new System.Drawing.Size(156, 28);
            this.cmbKatTip.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(690, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Masa Sayisi:";
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Location = new System.Drawing.Point(831, 24);
            this.txtMasaSayisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(114, 27);
            this.txtMasaSayisi.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(962, 21);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 35);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1293, 551);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.Btn_Click);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnMenuyeGec
            // 
            this.btnMenuyeGec.Location = new System.Drawing.Point(1150, 17);
            this.btnMenuyeGec.Name = "btnMenuyeGec";
            this.btnMenuyeGec.Size = new System.Drawing.Size(140, 41);
            this.btnMenuyeGec.TabIndex = 9;
            this.btnMenuyeGec.Text = "Devam Et";
            this.btnMenuyeGec.UseVisualStyleBackColor = true;
            this.btnMenuyeGec.Click += new System.EventHandler(this.btnMenuyeGec_Click);
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 727);
            this.Controls.Add(this.btnMenuyeGec);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMasaSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKatTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKat);
            this.Controls.Add(this.label1);
            this.Name = "Choice";
            this.Text = "Choice";
            this.Load += new System.EventHandler(this.Choice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKatSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKatTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasaSayisi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMenuyeGec;
    }
}