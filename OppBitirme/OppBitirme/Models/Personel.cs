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
        
        Enumlar.Branslar IBrans.branslar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
