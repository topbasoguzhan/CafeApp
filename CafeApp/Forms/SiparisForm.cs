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
    public partial class SiparisForm : Form
    {
        private Masa ramMasa = new Masa();
        public SiparisForm(Masa masa)
        {
            ramMasa = masa;
            
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = ramMasa.MasaID;
        }

        private void lblMasaNo_Click(object sender, EventArgs e)
        {

        }
    }
}
