using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeApp.Models;
using Newtonsoft.Json;

namespace CafeApp.Forms
{
    public partial class SiparisForm : Form
    {
        private Masa ramMasa = new Masa();
        public static string _path = "C://KafeEnvanteri//db.json";
        KafeVeri kafeDb = new KafeVeri();
        public BindingList<Urun> SiparislerList = new BindingList<Urun>();
        public SiparisForm(Masa masa)
        {
            ramMasa = masa;
            
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            
            VeritabaniOku();
            kafeDb.SiparisList = new List<Siparis>();
            cmbUrunler.Items.AddRange(kafeDb.MenuList.ToArray());
            lblMasaNo.Text = ramMasa.MasaID;
            dgvSiparisler.DataSource =SiparislerList;

        }

        private void lblMasaNo_Click(object sender, EventArgs e)
        {

        }
        public void VeritabaniOku()
        {

            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();

                    kafeDb = JsonConvert.DeserializeObject<KafeVeri>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory("C://KafeEnvanteri");
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis()
            {
                SiparisDateTime = DateTime.Now,
                SiparisMasasi = ramMasa,
                TeslimEdildiMi = false,
                
            };

            siparis.UrunlerList = new List<Urun>();
            for (int i = 1; i <= nmrAdet.Value; i++)
            {
                siparis.UrunlerList.Add((Urun)cmbUrunler.SelectedItem);
                SiparislerList.Add((Urun)cmbUrunler.SelectedItem);
            }
            kafeDb.SiparisList.Add(siparis);
            
        }

        private void btnMasalaraDon_Click(object sender, EventArgs e)
        {
            Masaİslemleri masaİslemleri = new Masaİslemleri();
            masaİslemleri.Show();

        }                               
    }
}
