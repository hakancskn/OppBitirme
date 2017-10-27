using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Hasta:Kisi
    {

        public override string TcknValid(string tckn)
        {
            if (Hastane.Hastalar.Where(x => x.Tckn == tckn).Count() > 1)
            {
                throw new Exception("Bu kişi zaten kaydedilmiş");

            }
            return base.TcknValid(tckn);
        }

    }
}
