using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    
    public class Kat
    {
        //public KatYapisi KatTipleri { get; set; }

        //public Kat(KatYapisi kat)
        //{
        //    this.KatTipleri = kat;
        //}

       
        public int KatSayisi { get; set; }

        public int KattakiMasalar { get; set; }

        //public List<Masa> KatMasalari { get; set; }

        public List<Alan> Alanlar { get; set; }
        
        
    }
}
