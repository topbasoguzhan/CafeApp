using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeApp.Models;
using CafeApp.Properties;
using Newtonsoft.Json;

namespace CafeApp.Forms
{
    public partial class Masaİslemleri : Form
    {
        public static string _path = "C://KafeEnvanteri//db.json";
        KafeVeri kafeDb = new KafeVeri();
        private Button btn;
        public List<Masa> MasalarList = new List<Masa>();
        public List<Button> butonlar = new List<Button>();
        public Masa DegiskenMasa = new Masa();
        public Masaİslemleri()
        {
            InitializeComponent();
            kafeDb.KatList = new List<Kat>();
        }
        public Masaİslemleri(KafeVeri kafeDDisardanGeKafeDb)
        {
            InitializeComponent();
            kafeDb = kafeDDisardanGeKafeDb;

        }
        public Masaİslemleri(Masa MasaDisaridanGelen,KafeVeri disaridanKafeVeri)
        {
            InitializeComponent();
            kafeDb = disaridanKafeVeri;
            DegiskenMasa = MasaDisaridanGelen;


            if (DegiskenMasa.Id != null)
            {
                foreach (Masa masa in kafeDb.MasaList)
                {
                    if (DegiskenMasa.Id == masa.Id)
                    {
                        //
                        foreach (var button in butonlar)
                        {
                            if (masa.Id == button.TabIndex)
                            {
                                button.BackgroundImage = Properties.Resources.logo_doluMasa;
                                masa.MüsaitMi = false;
                            }
                        }
                    }
                }
            }
            kafeDb.VeritabaninaYaz(_path,kafeDb);

        }
        
        private void Masaİslemleri_Load(object sender, EventArgs e)
        {
            //VeritabaniOku();
            MasalarList = kafeDb.MasaList;
            if (MasalarList.Count != 0)
            {
                MasaOlustur();
            }



            if (DegiskenMasa.MasaID != null)
            {
                foreach (var button in butonlar)
                {
                    if (button.Text == DegiskenMasa.MasaID)
                    {
                        button.BackgroundImage = Resources.logo_doluMasa;
                    }
                }
            }



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
        private void Btn_Click(object? sender, EventArgs e)
        {
            int x = (sender as Button).TabIndex;
            foreach (var masa in MasalarList)
            {
                if (masa.Id==x)
                {
                    this.Hide();
                    SiparisForm siparisForm = new SiparisForm(masa,kafeDb);
                    siparisForm.Show(); 
                }
            }
           
        }

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Masa masa in MasalarList)
            {
                if (btn.Text == masa.MasaID)
                {
                    this.Hide();
                    SiparisForm siparisForm = new SiparisForm(masa);
                    siparisForm.Show();
                }
            }
        }

        public void BtnImageChange(Masa masa)
        {
            foreach (Button control in flowLayoutPanel1.Controls.Cast<Button>())
            {
                if (control.Text == masa.MasaID)
                {
                    control.BackgroundImage = Properties.Resources.logo_doluMasa;
                }
            }
        }

        public void MasaOlustur()
        {
            foreach (var kat in kafeDb.KatList)
            {
                foreach (var alan in kat.Alanlar)
                {
                    string alanAdi = alan.KatTipi;
                    string bulundugukat = alan.BulunduguKat.ToString();
                    for (int i = 1; i <= alan.MasaList.Count; i++)
                    {
                        Masa masa = new Masa()
                        {
                            MasaID = bulundugukat + '.' + alanAdi + "." + Convert.ToInt32(i),
                            MasaninBulunduguKat = bulundugukat,
                            MasaninKatTipi = alanAdi,
                            MüsaitMi = true
                        };
                        btn = new Button();
                        btn.Text = masa.MasaID;
                        btn.Width = 150;
                        btn.Height = 100;
                        btn.AutoSize = false;
                        var margin = btn.Margin;
                        margin.Left = 4;
                        margin.Right = 4;
                        margin.Top = 4;
                        margin.Bottom = 4;
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.DarkRed;
                        btn.Font = new Font("Segoe UI",7,FontStyle.Bold);
                        btn.Margin = new Padding(2);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.logo_default;
                        btn.Click += Btn_Click;
                        btn.TabIndex = i;
                        masa.Id = i;
                        butonlar.Add(btn);
                        flowLayoutPanel1.Controls.Add(btn);
                        MasalarList.Add(masa);
                        kafeDb.MasaList.Add(masa);
                        alan.MasaList.Add(masa);
                    }
                }
            }
        }

        
        

    }
}
