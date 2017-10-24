using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Kisi
    {

        public void Cast(Kisi kisi)
        {
            this.Ad = kisi.Ad;
            this.Adres = kisi.Adres;
            this.cinsiyet = kisi.cinsiyet;
            this.DogumTarihi = kisi.DogumTarihi;
            this.Mail = kisi.Mail;
            this.Soyad = kisi.Soyad;
            this.Tckn = kisi.Tckn;
            this.Telefon = kisi.Telefon;
            this.unvan = kisi.unvan;
            

        }

        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Tckn { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet cinsiyet { get; set; }
        public String Telefon { get; set; }
        public String Adres { get; set; }
        public String Mail { get; set; }
        public Unvan unvan { get; set; }

        public String AdSoyad { get { return Ad + " " + Soyad; } }
        public enum Cinsiyet
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
