using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public class Menu
    {
        public List<Urun> UrunList { get; set; }

        public void UrunYukle()
        {
            Urun urun = new Urun();
            urun.UrunAciklama = "Deneme";
            urun.UrunAd = "Deneme Ürünü";
            urun.UrunFiyat = 100.0;
            //urun.UrunId // linq sorgusu ile json üzerinden ürünleri okuyarak en son eklenen ürünün bir sonraki indeksini otomatik alacak // outo increment oi
            //urun.UrunGorseli
            urun.UrunStok = 10;
            
        }
        
    }
}
