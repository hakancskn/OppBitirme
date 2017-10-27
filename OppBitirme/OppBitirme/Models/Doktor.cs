using OppBitirme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Doktor : Kisi, IServis
    {

        public override string TcknValid(string tckn)
        {
            if (Hastane.Doktorlar.Where(x => x.Tckn == tckn).Count() > 0)
            {
                throw new Exception("Bu kişi zaten kaydedilmiş");

            }
            return base.TcknValid(tckn);
        }

        public Hastane.Servisler Servis { get; set; }
       // public List<Hemsire> Hemsireleri { get; set; } = new List<Hemsire>();
    }
}
