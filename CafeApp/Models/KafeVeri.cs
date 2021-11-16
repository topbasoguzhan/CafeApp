﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CafeApp.Models
{
    public class KafeVeri
    {
        public List<Masa> MasaList { get; set; }
        public string KafeAdi { get; set; }
        public int KatSayisi { get; set; }
        public List<Kat> KatList { get; set; }
        public List<Menu> MenuList { get; set; }

        public void VeritabaniOku(string str,KafeVeri kafeDb)
        {

            if (File.Exists(str))
            {
                try
                {
                    FileStream fileStream = new FileStream(str, FileMode.Open);
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

        public void VeritabaninaYaz(string str,KafeVeri kafeDb)
        {
            try
            {
                FileStream fileStream = new FileStream(str, FileMode.OpenOrCreate);
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

    }
}
