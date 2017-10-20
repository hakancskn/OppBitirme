using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Hastane
    {
        public List<Doktor> Doktorlar { get; set; }
        public List<Personel> Personeller { get; set; }
        public List<Hemsire> Hemsireler { get; set; }
        public List<Hasta> Hastalar { get; set; }
        public List<Randevu> Randevular { get; set; }



        enum Servisler
        {


        }

    }
}
