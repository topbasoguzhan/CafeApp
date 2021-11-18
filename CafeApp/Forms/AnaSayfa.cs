using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeApp.Models;

namespace CafeApp.Forms
{
    public partial class AnaSayfa : Form
    {
        public KafeVeri KafeDb = new KafeVeri();
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public AnaSayfa(KafeVeri kafeVeriDb)
        {
            InitializeComponent();
            KafeDb = kafeVeriDb;
        }

        private void btnMasaİslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masaİslemleri masaİslemleri = new Masaİslemleri(KafeDb);
            masaİslemleri.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
