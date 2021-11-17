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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnMasaİslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masaİslemleri masaİslemleri = new Masaİslemleri();
            masaİslemleri.Show();
        }
    }
}
