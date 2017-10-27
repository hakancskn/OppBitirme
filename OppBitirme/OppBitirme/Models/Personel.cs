using OppBitirme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Personel : Kisi, IBrans
    {

        public override string TcknValid(string tckn)
        {
            if (Hastane.Personeller.Where(x => x.Tckn == tckn).Count() > 0)
            {
                throw new Exception("Bu kişi zaten kaydedilmiş");

            }
            return base.TcknValid(tckn);
        }
        public Hastane.Branslar brans { get; set ; }
    }
}
