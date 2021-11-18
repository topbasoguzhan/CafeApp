using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public class Masa
    {
        private bool _müsaitMi = true;
        public int Id { get; set; }
        public bool MüsaitMi
        {
            get
            {
                return _müsaitMi;
            }
            set
            {
                _müsaitMi = value;
            }
        } //garson masaya müşteri alabilir mi alamaz mı bunun değerini tutar

        public string MasaninBulunduguKat { get; set; }
        public string MasaninKatTipi { get; set; }
        public string MasaID { get; set; }
        

        public List<Siparis> SiparisList { get; set; }

    }
}
