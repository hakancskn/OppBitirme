using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public  class Arama
    {
        public static void ListedeArama<T>(string Aranan, ref List<T> list)
        {

            if (list is List<Hasta>)
            {
                List<Hasta> liste = Hastane.Hastalar.Where(x => x.Ad.ToLower().Contains(Aranan) || x.Soyad.Contains(Aranan) || x.Tckn.Contains(Aranan)).ToList();
                list.Clear();
                for (int i = 0; i < liste.Count(); i++)
                {
                    (list as List<Hasta>).Add(liste[i]);
                }

            }
            else if (list is List<Doktor>)
            {
                List<Doktor> liste = Hastane.Doktorlar.Where(x => x.Ad.ToLower().Contains(Aranan) || x.Soyad.Contains(Aranan) || x.Tckn.Contains(Aranan)).ToList();
                list.Clear();
                for (int i = 0; i < liste.Count(); i++)
                {
                    (list as List<Doktor>).Add(liste[i]);
                }

            }
            else if (list is List<Personel>)
            {
                List<Personel> liste = Hastane.Personeller.Where(x => x.Ad.ToLower().Contains(Aranan) || x.Soyad.Contains(Aranan) || x.Tckn.Contains(Aranan)).ToList();
                list.Clear();
                for (int i = 0; i < liste.Count(); i++)
                {
                    (list as List<Personel>).Add(liste[i]);
                }

            }
            else if (list is List<Hemsire>)
            {
                List<Hemsire> liste = Hastane.Hemsireler.Where(x => x.Ad.ToLower().Contains(Aranan) || x.Soyad.Contains(Aranan) || x.Tckn.Contains(Aranan)).ToList();
                list.Clear();
                for (int i = 0; i < liste.Count(); i++)
                {
                    (list as List<Hemsire>).Add(liste[i]);
                }

            }



        }
    }
}
