using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeApp.Models
{
    public class Alan  
    {
        public int BulunduguKat { get; set; }
        public string KatTipi { get; set; }
        public int MasaSayisi { get; set; }
        public List<Masa> MasaList { get; set; }

        public string AlanAdi { get; set; }
       
    }
}
