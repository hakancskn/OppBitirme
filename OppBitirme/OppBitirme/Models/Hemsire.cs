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
        public string DoktorTckn { get; set; }

        public override string TcknValid(string tckn)
        {
            if (Hastane.Hemsireler.Where(x => x.Tckn == tckn).Count() > 0)
            {
                throw new Exception("Bu kişi zaten kaydedilmiş");
               
            }
            return base.TcknValid(tckn);
        }

    }
}
