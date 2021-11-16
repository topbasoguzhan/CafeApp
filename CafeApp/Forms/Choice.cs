using CafeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp.Forms
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();

        }
        public Kat KatBilgisi { get; set; }

        private void Choice_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= KatBilgisi.KatSayisi; i++)
            {
                cmbKat.Items.Add(i.ToString());
            }
             
             
             cmbKatTip.DataSource = Enum.GetNames(typeof(KatTipi.KatYapisi));

        }

        Button btn;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();

            Kat kat = new Kat()
            {
                KattakiMasalar = int.Parse(txtMasaSayisi.Text)
            };

            for (int i = 1; i <= kat.KattakiMasalar; i++)
            {
                btn=new Button();
                
                btn.Text = $"M{cmbKat.SelectedItem + Convert.ToString(cmbKatTip.SelectedItem).Substring(0, 1).ToUpper() + i.ToString()}";
                btn.Width = 150;
                btn.Height = 100;
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.Red;
                btn.Margin = new  Padding(2);
                btn.Click += Btn_Click;
                btn.TabIndex = i;
                flowLayoutPanel1.Controls.Add(btn);    
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

       
    }
}