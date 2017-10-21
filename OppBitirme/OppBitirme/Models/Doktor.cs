using OppBitirme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Doktor : Kisi, IServis,IHemsireAlabilen
    {
        public Hastane.Servisler Servis { get; set; }
        public List<Hemsire> Hemsireleri { get; set; }
    }
}
