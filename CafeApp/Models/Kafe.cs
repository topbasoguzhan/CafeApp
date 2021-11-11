using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public class Kafe
    {
        public List<Kat> KatList { get; set; }//kafedei salon bahçe teras vs katları tutmak için 

        public List<Masa> MasalarList { get; set; }//kafedeki toplam masa nesnesi

        public List<Siparis> TeslimEdilenSiparisler { get; set; }// z raporu veri içeriği

    }
}
