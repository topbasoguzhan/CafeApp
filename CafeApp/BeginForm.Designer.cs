﻿namespace CafeApp
{
    partial class BeginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeginForm));
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKatBilgisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKafeAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKaydet1.BackgroundImage = global::CafeApp.Properties.Resources.istockphoto_816807384_612x612;
            this.btnKaydet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet1.Location = new System.Drawing.Point(125, 94);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(529, 345);
            this.btnKaydet1.TabIndex = 0;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kafe uygulamamıza hoşgeldiniz! Lütfen adımları takip ediniz.";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kat sayısını giriniz:";
            // 
            // txtKatBilgisi
            // 
            this.txtKatBilgisi.AllowDrop = true;
            this.txtKatBilgisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKatBilgisi.Location = new System.Drawing.Point(267, 52);
            this.txtKatBilgisi.Name = "txtKatBilgisi";
            this.txtKatBilgisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKatBilgisi.Size = new System.Drawing.Size(125, 27);
            this.txtKatBilgisi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(398, 55);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kafe adını giriniz:";
            // 
            // txtKafeAdi
            // 
            this.txtKafeAdi.AllowDrop = true;
            this.txtKafeAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKafeAdi.Location = new System.Drawing.Point(531, 52);
            this.txtKafeAdi.Name = "txtKafeAdi";
            this.txtKafeAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKafeAdi.Size = new System.Drawing.Size(123, 27);
            this.txtKafeAdi.TabIndex = 5;
            this.txtKafeAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CafeApp.Properties.Resources.GirisEkranArkaplan;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.txtKafeAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKatBilgisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeginForm";
            this.Text = "YOV CafeApp V1";
            this.Load += new System.EventHandler(this.BeginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKatBilgisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKafeAdi;
    }
}
