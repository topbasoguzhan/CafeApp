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

           public Kat MasaninKati { get; set; }    


    }
}
