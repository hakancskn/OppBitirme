using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class Kisi
    {
        private DateTime _dogumTarihi;

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
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = DogumTarihiValid(value); }
        }
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

        public string AdSoyadValid(string kelime)
        {
            string adsoyad = kelime.Trim();

            foreach (char harf in adsoyad)
            {
                if (!char.IsLetter(harf) || char.IsWhiteSpace(harf))
                    throw new Exception("Ad veya soyad içerisinde geçersiz karakter bulunmaktadır!");
            }
            if (adsoyad.Length < 2)
                throw new Exception("Ad veya soyad en az 2 karakter olmalı");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adsoyad);
        }
        public string TcknValid(string tckn)
        {
            if (tckn.Length != 11)
                throw new Exception("T.C. Kimlik numarası 11 haneli olmalıdır.");
            foreach (char harf in tckn)
           if (!char.IsDigit(harf))
                    throw new Exception("T.C. Kimlik numarası içerisinde sadece rakam bulunmalıdır.");
            if (Convert.ToInt32(tckn[10]) % 2 != 0)
                throw new Exception("T.C.Kimlik numarasının son rakamı çift olmalıdır.");
            if (tckn[0] == '0')
                throw new Exception("T.C. Kimlik numarası '0' ile başlayamaz.");
            return tckn;
        }
        public DateTime DogumTarihiValid (DateTime dogumTarihi)
        {
            if (dogumTarihi > DateTime.Now)
                throw new Exception("Lütfen doğum tarihi bilgisini kontrol ediniz.");
            return dogumTarihi;
        }


    }
}
