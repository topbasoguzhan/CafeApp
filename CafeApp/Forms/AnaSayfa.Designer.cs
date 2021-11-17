
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMasaİslemleri = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMasaİslemleri
            // 
            this.btnMasaİslemleri.Location = new System.Drawing.Point(654, 171);
            this.btnMasaİslemleri.Name = "btnMasaİslemleri";
            this.btnMasaİslemleri.Size = new System.Drawing.Size(282, 235);
            this.btnMasaİslemleri.TabIndex = 1;
            this.btnMasaİslemleri.Text = "Masa İşlemleri";
            this.btnMasaİslemleri.UseVisualStyleBackColor = true;
            this.btnMasaİslemleri.Click += new System.EventHandler(this.btnMasaİslemleri_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.Location = new System.Drawing.Point(26, 171);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(282, 235);
            this.btnZRaporu.TabIndex = 2;
            this.btnZRaporu.Text = "Z Raporu";
            this.btnZRaporu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 235);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnMasaİslemleri);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnMasaİslemleri;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.Button button1;
    }
}