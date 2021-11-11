using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public class Siparis
    {
        private DateTime _siparisDateTime,_siparisTeslimDateTime;
        public List<Urun> UrunlerList { get; set; }
        public Masa SiparisMasasi { get; set; }
        public DateTime SiparisDateTime
        {
            get { return _siparisDateTime;}
            set { _siparisDateTime = DateTime.Now; }
        }
        public DateTime SiparisTeslimDateTime
        {
            get { return _siparisTeslimDateTime; }
            set { _siparisTeslimDateTime = DateTime.Now; }
        }

        public bool TeslimEdildiMi { get; set; }




    }
}
