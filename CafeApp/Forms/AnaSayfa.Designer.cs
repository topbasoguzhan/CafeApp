
namespace CafeApp.Forms
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnMasaİslemleri = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasaİslemleri
            // 
            this.btnMasaİslemleri.BackgroundImage = global::CafeApp.Properties.Resources.RestoranResim;
            this.btnMasaİslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasaİslemleri.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasaİslemleri.ForeColor = System.Drawing.Color.Yellow;
            this.btnMasaİslemleri.Location = new System.Drawing.Point(48, 177);
            this.btnMasaİslemleri.Name = "btnMasaİslemleri";
            this.btnMasaİslemleri.Size = new System.Drawing.Size(259, 138);
            this.btnMasaİslemleri.TabIndex = 1;
            this.btnMasaİslemleri.Text = "Masa İşlemleri";
            this.btnMasaİslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMasaİslemleri.UseVisualStyleBackColor = true;
            this.btnMasaİslemleri.Click += new System.EventHandler(this.btnMasaİslemleri_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.BackgroundImage = global::CafeApp.Properties.Resources.zReport;
            this.btnZRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZRaporu.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZRaporu.Location = new System.Drawing.Point(48, 39);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(259, 132);
            this.btnZRaporu.TabIndex = 2;
            this.btnZRaporu.Text = "Z Raporu";
            this.btnZRaporu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnZRaporu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 120);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeApp.Properties.Resources._1306126;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnMasaİslemleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMasaİslemleri;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.Button button1;
    }
}