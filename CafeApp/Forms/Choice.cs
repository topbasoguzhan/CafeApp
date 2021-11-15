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
            for (int i = 0; i < KatBilgisi.KatSayisi; i++)
            {
                cmbKat.Items.Add(i.ToString());
            }

        }

        
    }
}