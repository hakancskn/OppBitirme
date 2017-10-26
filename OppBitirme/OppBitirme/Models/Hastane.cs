using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OppBitirme.Models
{
    public static  class  Hastane
    {
        public static DateTime AcilisSaati { get; set; }
        public static DateTime KapanisSaati { get; set; }
        public static DateTime PaydosBaslangic { get; set; }
        public static DateTime PaydosBitis { get; set; }
        public static List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public static List<Personel> Personeller { get; set; } = new List<Personel>();
        public static List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public static List<Hasta> Hastalar { get; set; } = new List<Hasta>();

        public static List<Randevu> Randevular { get; set; } = new List<Randevu>();

        public enum Servisler
        {
            Kardiyoloji,
            Göz


        }
        public enum Branslar
        {
        dsa
        }


      

    }
}
