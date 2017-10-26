using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppBitirme.Models
{
    public class DosyaIslemleri
    {


        public DateTime AcilisSaati {
            get { return Hastane.AcilisSaati; }
            set { Hastane.AcilisSaati = this.AcilisSaati; }
        }
        public DateTime KapanisSaati
        {
            get { return Hastane.KapanisSaati; }
            set { Hastane.KapanisSaati = this.KapanisSaati; }
        } 
        public DateTime PaydosBaslangic {
            get { return Hastane.PaydosBaslangic; }
            set { Hastane.PaydosBaslangic = this.PaydosBaslangic; }
        }
        public DateTime PaydosBitis {
            get { return Hastane.PaydosBitis; }
            set { Hastane.PaydosBitis = this.PaydosBitis; }
        }
        public  List<Doktor> Doktorlar {
            get { return Hastane.Doktorlar; }
            set { Hastane.Doktorlar= this.Doktorlar; }
        }
        public  List<Personel> Personeller {
            get { return Hastane.Personeller; }
            set { Hastane.Personeller = this.Personeller; }

        } 
        public  List<Hemsire> Hemsireler {
            get { return Hastane.Hemsireler; }
            set { Hastane.Hemsireler = this.Hemsireler; }
        } 
        public  List<Hasta> Hastalar {
            get { return Hastane.Hastalar; }
            set { Hastane.Hastalar = this.Hastalar; }
        } 

        public  List<Randevu> Randevular {
            get { return Hastane.Randevular; }
            set { Hastane.Randevular = this.Randevular; }
        } 

    



    }
}
