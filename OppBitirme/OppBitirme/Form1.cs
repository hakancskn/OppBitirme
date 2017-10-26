using OppBitirme.Models;
using OppBitirme.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OppBitirme.Models.Kisi;

namespace OppBitirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        KisiEkle kisiEkleme;

        YeniRandevuEkrani randevuEkran;
        GuncelleEkran guncelle;
        private void Form1_Load(object sender, EventArgs e)
        {
       
            
            Hastane.AcilisSaati = new DateTime().AddHours(9);
            Hastane.KapanisSaati = Hastane.AcilisSaati.AddHours(8);
            Hastane.PaydosBaslangic = Hastane.AcilisSaati.AddHours(4);
            Hastane.PaydosBitis = Hastane.PaydosBaslangic.AddHours(1);
    
         

            Hemsire hemsire2 = new Hemsire();

            hemsire2.Ad = "dasds";
            hemsire2.Mail = "sadsd0";
            hemsire2.Soyad = "asdsd";
            hemsire2.Servis = Hastane.Servisler.Kardiyoloji;
           



           
            
            Doktor doktor2 = new Doktor();
           // doktor2.Hemsireleri.Add(hemsire2);
            doktor2.Ad = "hakasdsdan";
            doktor2.Soyad = "coşkuasdsdn";
            doktor2.Tckn = "15143256030";
            doktor2.Telefon = "05387299810";
            doktor2.unvan = Kisi.Unvan.Doktor;
            doktor2.cinsiyet = Cinsiyet.Erkek;
            doktor2.DogumTarihi = DateTime.Now;
            doktor2.unvan = Kisi.Unvan.Doktor;
            doktor2.Servis = Hastane.Servisler.Göz;
            doktor2.Servis = Hastane.Servisler.Kardiyoloji;
            hemsire2.Doktoru = doktor2;
            Hastane.Hemsireler.Add(hemsire2);
            Hastane.Doktorlar.Add(doktor2);


            //hastane.xml();
           
            Hemsire hemsa = new Hemsire();
            Hasta hasta = new Hasta();
            hasta.Ad = "Murat";
            hasta.Soyad = "ciguli";
            hasta.Telefon = "12545";
            hasta.Tckn = "15143256030";
            Hastane.Hastalar.Add(hasta);
            Hasta hasta2 = new Hasta();
            hasta2.Ad = "Musadasdasdrat";
            hasta2.Soyad = "sdasd";
            hasta2.Telefon = "asdsad";
            hasta2.Tckn = "15143256030";
            Hastane.Hastalar.Add(hasta2);
            
            DısaAktar.Json();

          

            this.LayoutMdi(MdiLayout.TileVertical);
        }

     

       

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randevuEkran = new YeniRandevuEkrani();
            panel1.Controls.Clear();
            panel1.Controls.Add(randevuEkran);
        }

      

        private void KisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            kisiEkleme = new KisiEkle();
            kisiEkleme.Unvani = (Unvan)(sender as ToolStripMenuItem).Tag;
            panel1.Controls.Clear();
            panel1.Controls.Add(kisiEkleme);
        }

        private void KisiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle= new GuncelleEkran();
            guncelle.unvan = (Unvan)(sender as ToolStripMenuItem).Tag;
            panel1.Controls.Clear();
            panel1.Controls.Add(guncelle);

            

        }


    }
}
