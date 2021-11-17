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
using Newtonsoft.Json;

namespace CafeApp.Forms
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        public static string _path = "C://KafeEnvanteri//db.json";
        KafeVeri kafeDb = new KafeVeri();
        public BindingList<Urun> ListeofBindingList;
        private void Urunler_Load(object sender, EventArgs e)
        {
            VeritabaniOku();

            kafeDb.MenuList = new List<Urun>();

            ListeofBindingList = new BindingList<Urun>();
            dgvUrunler.DataSource = ListeofBindingList;

            //dgvUrunler.ReadOnly = true;
            //dgvUrunler.AllowUserToAddRows = false;
            //dgvUrunler.ColumnCount = 4;
            //dgvUrunler.Columns[0].Name = "Urun Adi";
            //dgvUrunler.Columns[1].Name = "Urun Aciklamasi";
            //dgvUrunler.Columns[2].Name = "Urun Fiyati";
            //dgvUrunler.Columns[3].Name = "Urun Stok";
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun()
            {
                UrunAd = txtUrunAd.Text,
                UrunAciklama = txtUrunAciklamasi.Text,
                UrunFiyat = Convert.ToDouble(txtFiyat.Text),
                UrunStok = Convert.ToInt32(txtUrunStok.Text),

            };
            if (pbUrunResim.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                pbUrunResim.Image.Save(memoryStream, ImageFormat.Jpeg);
                urun.UrunGorsel = memoryStream.ToArray();
            }

            kafeDb.MenuList.Add(urun);
            kafeDb.VeritabaninaYaz(_path, kafeDb);
            //dgvUrunler.Rows.Add(urun.UrunAd, urun.UrunAciklama, urun.UrunFiyat, urun.UrunStok);
            ListeofBindingList.Add(urun);


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

        private void pbUrunResim_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // masaüstünü göstermesi için
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";        // dosya filtrelemesi
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string s in openFileDialog1.FileNames)     // multi select özelliği için kullanılabilir
                            {
                                pbUrunResim.ImageLocation = s;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvUrunlerSelectedRow in dgvUrunler.SelectedRows)
            {
                dgvUrunler.Rows.RemoveAt(dgvUrunlerSelectedRow.Index);
            }//veritabanından silinme operasyonu yazılacak
            
            Urun urun = new Urun()
            {
                UrunAd = txtUrunAd.Text,
                UrunAciklama = txtUrunAciklamasi.Text,
                UrunFiyat = Convert.ToDouble(txtFiyat.Text),
                UrunStok = Convert.ToInt32(txtUrunStok.Text),

            };
            if (pbUrunResim.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                pbUrunResim.Image.Save(memoryStream, ImageFormat.Jpeg);
                urun.UrunGorsel = memoryStream.ToArray();
            }

            kafeDb.MenuList.Add(urun);
            kafeDb.VeritabaninaYaz(_path, kafeDb);
            //dgvUrunler.Rows.Add(urun.UrunAd, urun.UrunAciklama, urun.UrunFiyat, urun.UrunStok);
            ListeofBindingList.Add(urun);
        }

       

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvUrunler_MouseClick(object sender, MouseEventArgs e)
        {
            string ad = dgvUrunler.SelectedRows[0].Cells[1].Value + string.Empty;
            txtUrunAd.Text = ad;
            string aciklama = dgvUrunler.SelectedRows[0].Cells[3].Value + string.Empty;
            txtUrunAciklamasi.Text = aciklama;
            string fiyat = dgvUrunler.SelectedRows[0].Cells[2].Value + string.Empty;
            txtFiyat.Text = fiyat;
            string stok = dgvUrunler.SelectedRows[0].Cells[4].Value + string.Empty;
            txtUrunStok.Text = stok;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvUrunlerSelectedRow in dgvUrunler.SelectedRows)
            {
                dgvUrunler.Rows.RemoveAt(dgvUrunlerSelectedRow.Index);
            }//veritabınından silme operasyonu uygulancak
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }
    }
}
