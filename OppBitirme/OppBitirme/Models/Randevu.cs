using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OppBitirme.Models.Hastane;

namespace OppBitirme.Models
{
    public class Randevu
    {
        public Hasta hasta { get; set; }
        public Doktor doktor { get; set; }
        public DateTime Zamani { get; set; }
        public Servisler Servisi { get; set; }
        public override string ToString()
        {
            return hasta.AdSoyad+" "+Servisi+" "+doktor+" "+Zamani;

        }


    }
}
