using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Kisi
    {
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Tckn { get; set; }
        public DateTime  DogumTarihi { get; set; }
        public Cinsiyet cinsiyet { get; set; }
        public String Telefon { get; set; }
        public String Adres { get; set; }
        public String Mail { get; set; }
        public Unvan unvan { get; set; }

        public enum  Cinsiyet
    {
        Erkek,
        Kadın,
        Belirsiz
    };

        public enum Unvan
        {
          Hasta,
          Personel,
          Doktor,
          Hemşire,

        }



    }
}
