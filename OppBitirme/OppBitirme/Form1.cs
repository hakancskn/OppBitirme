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


namespace OppBitirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        KisiEkle kisi;

        YeniRandevuEkrani randevuEkran=new YeniRandevuEkrani();
        private void Form1_Load(object sender, EventArgs e)
        {
            Hastane hastane = new Hastane();
            Doktor doktor = new Doktor();
            doktor.Ad = "hakan";
            doktor.Soyad = "coşkun";
            doktor.Tckn = "15143256030";
            doktor.Telefon = "05387299810";
            doktor.unvan = Kisi.Unvan.Doktor;
            doktor.Servis = Hastane.Servisler.das;
            Hastane.Doktorlar.Add(doktor);
            Hemsire hemsire = new Hemsire();
            hemsire.Ad = "dasds";
            hemsire.Mail = "sadsd0";
            hemsire.Soyad = "asdsd";
            Hastane.Hemsireler.Add(hemsire);
           //hastane.xml();
            kisi = new KisiEkle();
            Hemsire hemsa = new Hemsire();
            Hasta hasta = new Hasta();
            hasta.Ad = "Murat";
            hasta.Soyad = "ciguli";
            hasta.Telefon = "12545";
            hasta.Tckn = "15143256030";
            Hastane.Hastalar.Add(hasta);


            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncelleEkran guncelle = new GuncelleEkran();
            guncelle.unvan = Kisi.Unvan.Doktor;
            panel1.Controls.Clear();
            panel1.Controls.Add(guncelle);
        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panel1.Controls.Clear();
            panel1.Controls.Add(kisi);
        }

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(randevuEkran);
        }
    }
}
