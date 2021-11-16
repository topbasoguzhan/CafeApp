using CafeApp.Forms;
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

namespace CafeApp
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {

            Kat kat = new Kat()
            {
                 KatSayisi = int.Parse(txtKatBilgisi.Text),    
                 
            };


            Choice choice = new Choice();
            choice.KatBilgisi = kat;
            choice.Show();
            this.Hide();
         

        }

       
    }
}
