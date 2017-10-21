using OppBitirme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Hemsire : Kisi, IServis
    {
        public Hastane.Servisler Servis { get ; set; }
        public Doktor Doktoru { get; set; }
    }
}
