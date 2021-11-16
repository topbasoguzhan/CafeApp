using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeApp.Models;
using Newtonsoft.Json;

namespace CafeApp.Abstract
{
    public abstract class Utils
    {
        public KafeVeri kafeDb = new KafeVeri();
        public static string _path = "C://KafeEnvanteri//db.json";

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

        public void VeritabaninaYaz()
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
    }
}
