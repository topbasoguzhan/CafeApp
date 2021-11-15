namespace CafeApp
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
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKatBilgisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKaydet1.Location = new System.Drawing.Point(10, 59);
            this.btnKaydet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(360, 234);
            this.btnKaydet1.TabIndex = 0;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kafe uygulamamıza hoşgeldiniz! Lütfen adımları takip ediniz.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kat sayısını giriniz:";
            // 
            // txtKatBilgisi
            // 
            this.txtKatBilgisi.Location = new System.Drawing.Point(130, 27);
            this.txtKatBilgisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKatBilgisi.Name = "txtKatBilgisi";
            this.txtKatBilgisi.Size = new System.Drawing.Size(110, 23);
            this.txtKatBilgisi.TabIndex = 3;
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.txtKatBilgisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BeginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKatBilgisi;
    }
}
