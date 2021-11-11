using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Models
{
    public enum KatYapisi
    {
        Bahce,
        Teras,
        Salon,
        Havuz,

    }
    public class Kat
    {
        public KatYapisi KatTipleri { get; set; }

        public Kat(KatYapisi kat)
        {
            this.KatTipleri = kat;
        }










    }
}
