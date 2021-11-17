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
        public string UrunAd { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunAciklama { get; set; }
        public int UrunStok { get; set; }

        public byte[] UrunGorsel { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1:0.00}₺", UrunAd, UrunFiyat);
        }

    }
}
