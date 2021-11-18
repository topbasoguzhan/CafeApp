using CafeApp.Forms;
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
using CafeApp.Abstract;
using Newtonsoft.Json;

namespace CafeApp
{
    public partial class BeginForm : Form 
    {
        public BeginForm()
        {
            InitializeComponent();
        }
        public static string _path = "C://KafeEnvanteri//db.json";

        public KafeVeri kafeDb = new KafeVeri();

        private void btnKaydet1_Click(object sender, EventArgs e)
        {

            Kat kat = new Kat()
            {
                KatSayisi = int.Parse(txtKatBilgisi.Text),

            };

            kafeDb.KafeAdi = txtKafeAdi.Text;
            kafeDb.KatSayisi = Convert.ToInt32(txtKatBilgisi.Text);
            kafeDb.VeritabaninaYaz(_path, kafeDb);
            
            Choice choice = new Choice();
            choice.KatBilgisi = kat;
            choice.Show();
            this.Hide();

           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        //public void VeritabaniOku()
        //{

        //    if (File.Exists(_path))
        //    {
        //        try
        //        {
        //            FileStream fileStream = new FileStream(_path, FileMode.Open);
        //            StreamReader reader = new StreamReader(fileStream);
        //            string dosyaIcerigi = reader.ReadToEnd();
        //            reader.Close();
        //            reader.Dispose();
        //            kafeDb = JsonConvert.DeserializeObject<KafeVeri>(dosyaIcerigi);
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex);
        //        }
        //    }
        //    else
        //    {
        //        Directory.CreateDirectory("C://KafeEnvanteri");
        //    }
        //}

        //public void VeritabaninaYaz()
        //{
        //    try
        //    {
        //        FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
        //        StreamWriter writer = new StreamWriter(fileStream);
        //        writer.Write(JsonConvert.SerializeObject(kafeDb, Formatting.Indented));
        //        writer.Close();
        //        writer.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }



        //}
        private void BeginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
