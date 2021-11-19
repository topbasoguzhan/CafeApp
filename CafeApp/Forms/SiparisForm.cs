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
        public static string _pathAdisyon = "C://KafeEnvanteri//adisyon.txt";
        KafeVeri kafeDb = new KafeVeri();
        public BindingList<Urun> SiparislerList = new BindingList<Urun>();
        public SiparisForm(Masa masa)
        {
            ramMasa = masa;
            
            InitializeComponent();
        }
        public SiparisForm(Masa masa,KafeVeri DisaridangelenKafeDb)
        {
            ramMasa = masa;
            kafeDb = DisaridangelenKafeDb;
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            
           // VeritabaniOku();
            kafeDb.SiparisList = new List<Siparis>();
            cmbUrunler.Items.AddRange(kafeDb.MenuList.ToArray());
            lblMasaNo.Text = ramMasa.MasaID;
            dgvSiparisler.DataSource =SiparislerList;
            ramMasa.SiparisList = new List<Siparis>();
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
                TeslimEdildiMi = false,
                
            };
            
            siparis.UrunlerList = new List<Urun>();
            for (int i = 1; i <= nmrAdet.Value; i++)
            {
                siparis.UrunlerList.Add((Urun)cmbUrunler.SelectedItem);
                SiparislerList.Add((Urun)cmbUrunler.SelectedItem);
            }
            ramMasa.SiparisList.Add(siparis);
            kafeDb.SiparisList.Add(siparis);
            
        }

        private void btnMasalaraDon_Click(object sender, EventArgs e)
        {
            if (SiparislerList.Count()!=0)
            {
                ramMasa.MüsaitMi = false;
            }

            this.Hide();
            Masaİslemleri masaİslemleri = new Masaİslemleri(ramMasa,kafeDb);
            masaİslemleri.Show();
        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            //foreach (Siparis siparis in ramMasa.SiparisList)
            //{
            //    foreach (Urun urun in siparis.UrunlerList.ToList())
            //    {
                    
            //        if (dgvSiparisler.SelectedRows[0].Cells[1].ToString() == urun.UrunAd)
            //        {
            //            SiparislerList.Remove(urun);
            //            siparis.UrunlerList.Remove(urun);
            //        }
            //    }
            //}
            //foreach (Siparis siparis in kafeDb.SiparisList)
            //{
            //    foreach (Urun urun in siparis.UrunlerList.ToList())
            //    {
            //        if (dgvSiparisler.SelectedRows[0].Cells[1].ToString() == urun.UrunAd)
            //        {
            //            siparis.UrunlerList.Remove(urun);
                        
            //        }
            //    }
            //}

        }

        private void btnAdisyonYaz_Click(object sender, EventArgs e)
        {


            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(_pathAdisyon, false))
            {
                
                //file.WriteLine("  ");
                file.WriteLine("Masa No: " + ramMasa.MasaID); 
               
                file.WriteLine("--- Masa Detay : ---");
                file.WriteLine(" |  Ürün | Fiyat| Adet");
                string lines = "";

                for (int row = 0; row < ramMasa.SiparisList.Count; row++)
                {
                    for (int col = 0; col <=2; col++)
                    {

                        lines = lines + " | " + dgvSiparisler.Rows[row].Cells[col].Value.ToString();
                        if (col == 2)
                        {

                            file.WriteLine(lines);
                            lines = "";
                        }
                    }


                }
                file.WriteLine(" ------------------------");

                file.WriteLine(" Toplam :" + ramMasa.SiparisList.FirstOrDefault().UrunlerList.FirstOrDefault().UrunFiyat.ToString());

            }

            var print = new ProcessStartInfo("yazdir.txt");
            print.UseShellExecute = true;
            print.Verb = "print";
            var process = System.Diagnostics.Process.Start(print);
        }
    }
}
