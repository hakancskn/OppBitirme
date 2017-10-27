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
        public string hastaTckn { get; set; }
        public string doktorTckn { get; set; }
        public DateTime Zamani { get; set; }
        public Servisler Servisi { get; set; }
        public override string ToString()
        {
            return Hastane.Hastalar.Where(x=>x.Tckn==hastaTckn).First().AdSoyad+" "+Servisi+" "+ 
                Hastane.Doktorlar.Where(x => x.Tckn == doktorTckn).First().AdSoyad+ " "+Zamani;

        }


    }
}
