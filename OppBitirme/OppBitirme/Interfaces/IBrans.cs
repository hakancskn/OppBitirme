﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OppBitirme.Models.Enumlar;
using static OppBitirme.Models.Hastane;

namespace OppBitirme.Interfaces
{
    interface IBrans
    {
       Branslar  branslar { get; set; }
    }
}