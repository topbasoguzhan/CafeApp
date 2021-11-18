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
        public KafeVeri kafeDb = new KafeVeri();
        private Button btn;
        public List<Masa> MasalarList = new List<Masa>();
        public List<Masa> MasalarListİki = new List<Masa>();
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
        public Masaİslemleri(Masa MasaDisaridanGelen, KafeVeri disaridanKafeVeri)
        {
            InitializeComponent();
            kafeDb = disaridanKafeVeri;
            foreach (Masa masa in kafeDb.MasaList)
            {
                if (MasaDisaridanGelen.Id == masa.Id)
                {
                    masa.MüsaitMi = false;
                    //siparis kaydetme 
                    //siparis kaldırma
                }
            }
            //kafeDb.VeritabaninaYaz(_path,kafeDb);
            VeritabaniYaz();
            

            VeritabaniOku();
            
        }

        private void Masaİslemleri_Load(object sender, EventArgs e)
        {
            
            MasalarList = kafeDb.MasaList;

            if (kafeDb.MasaList[0].Id==0)//Masa üretilen cons
            {
                MasaOlustur();
            }
            else
            {
                MasaButonlariniGetir();
               
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

        public void VeritabaniYaz()
        {
            try
            {

                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(kafeDb, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            int x = (sender as Button).TabIndex;
            foreach (var masa in kafeDb.MasaList)
            {
                if (masa.Id == x)
                {
                    this.Hide();
                    SiparisForm siparisForm = new SiparisForm(masa, kafeDb);
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

       
        public void MasaOlustur()
        {
            foreach (var kat in kafeDb.KatList)
            {
                foreach (var alan in kat.Alanlar)
                {
                    int deg = alan.MasaList.Count;
                    alan.MasaList.Clear();
                    MasalarList.Clear();
                    string alanAdi = alan.KatTipi;
                    string bulundugukat = alan.BulunduguKat.ToString();
                    for (int i = 1; i <= deg; i++)
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
                        btn.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                        btn.Margin = new Padding(2);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.logo_default;
                        btn.Click += Btn_Click;
                        btn.TabIndex = i;
                        masa.Id = i;
                        butonlar.Add(btn);
                        
                        flowLayoutPanel1.Controls.Add(btn);
                        alan.MasaList.Add(masa);
                        //kafeDb.MasaList.Add(masa);
                        MasalarListİki.Add(masa);
                        
                    }
                }
            }
            kafeDb.MasaList.Clear();
            kafeDb.MasaList.AddRange(MasalarListİki);
            
            kafeDb.VeritabaninaYaz(_path,kafeDb);
        }

        public void MasaButonlariniGetir()
        {
            foreach (Masa masa in kafeDb.MasaList)
            {
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
                btn.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                btn.Margin = new Padding(2);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (masa.MüsaitMi==true)
                {
                    btn.BackgroundImage = Resources.logo_default;
                }
                else
                {
                    btn.BackgroundImage = Resources.logo_doluMasa;
                }
                btn.Click += Btn_Click;
                btn.TabIndex = masa.Id;
                butonlar.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }



    }
}
