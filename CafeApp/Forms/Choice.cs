using CafeApp.Models;
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
using Newtonsoft.Json;

namespace CafeApp.Forms
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();

        }
        public Kat KatBilgisi { get; set; }

        public KafeVeri kafeDb = new KafeVeri();
        

        public static string _path = "C://KafeEnvanteri//db.json";

        private void Choice_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= KatBilgisi.KatSayisi; i++)
            {
                cmbKat.Items.Add(i.ToString());
            }

            cmbKatTip.DataSource = Enum.GetNames(typeof(KatTipi.KatYapisi));
            VeritabaniOku();
            kafeDb.KatList = new List<Kat>();
            kafeDb.MasaList = new List<Masa>();
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



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Button btn;
            Kat kat = new Kat
            {
                KattakiMasalar = int.Parse(txtMasaSayisi.Text),
                Alanlar = new List<Alan>()
            };

            if (cmbKat.SelectedItem == null)
                MessageBox.Show("Lutfen bulundugu katı seciniz ");
            else
            {
                List<Masa> masalar = new List<Masa>();
                int masaSayisi = 0;
                for (int i = 1; i <= kat.KattakiMasalar; i++)
                {
                    btn = new Button();

                    btn.Text = $"M{cmbKat.SelectedItem + Convert.ToString(cmbKatTip.SelectedItem).Substring(0, 1).ToUpper() + i.ToString()}";
                    btn.Width = 150;
                    btn.Height = 100;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.Red;
                    btn.Margin = new Padding(2);
                    btn.Click += Btn_Click;
                    btn.TabIndex = i;
                    flowLayoutPanel1.Controls.Add(btn);

                    Masa masas = new Masa();
                    masalar.Add(masas);
                    masaSayisi++;

                }
                //kat.KatMasalari.AddRange(masalar);//oluşturulan yeni masayı masa listesine ekle
                Alan GecerliALan = new Alan
                {
                    MasaList = masalar.GetRange(0, Convert.ToInt32(masalar.Count)),
                    BulunduguKat = cmbKat.SelectedIndex,
                    KatTipi = cmbKatTip.SelectedItem.ToString(),
                    MasaSayisi = masaSayisi,
                    AlanAdi = cmbKat.SelectedIndex + ".kat" + cmbKatTip.SelectedItem.ToString()
                };

                MessageBox.Show("deneme");

                kat.Alanlar.Add(GecerliALan);
                kafeDb.KatList.Add(kat);
                kafeDb.MasaList.AddRange(masalar);
                kafeDb.VeritabaninaYaz(_path, kafeDb);
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnMenuyeGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler urunler = new Urunler();
            urunler.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}