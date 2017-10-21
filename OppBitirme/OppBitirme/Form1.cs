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
            hastane.Doktorlar.Add(doktor);
            Hemsire hemsire = new Hemsire();
            hemsire.Ad = "dasds";
            hemsire.Mail = "sadsd0";
            hemsire.Soyad = "asdsd";
            hastane.Hemsireler.Add(hemsire);
            hastane.xml();
            kisi = new KisiEkle();
            


            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncelleEkran guncelle = new GuncelleEkran(Kisi.Unvan.Doktor);
            panel1.Controls.Clear();
            panel1.Controls.Add(guncelle);
        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panel1.Controls.Clear();
            panel1.Controls.Add(kisi);
        }
    }
}
