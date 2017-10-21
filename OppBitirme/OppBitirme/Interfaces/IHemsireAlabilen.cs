using OppBitirme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Interfaces
{
   public  interface IHemsireAlabilen
    {
      List<Hemsire> Hemsireleri { get; set; }
    }
}
