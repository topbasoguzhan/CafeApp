using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunAciklamasi { get; set; }
        public int UrunStok { get; set; }
        public Bitmap UrunGorseli { get; set; }



    }
}
