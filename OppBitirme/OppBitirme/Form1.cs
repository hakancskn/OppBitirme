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
     
        Printer printer;

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiEkleme = new KisiEkle();
            panel1.Controls.Add(kisiEkleme);

            Hastane.AcilisSaati = new DateTime().AddHours(9);
            Hastane.KapanisSaati = Hastane.AcilisSaati.AddHours(8);
            Hastane.PaydosBaslangic = Hastane.AcilisSaati.AddHours(4);
            Hastane.PaydosBitis = Hastane.PaydosBaslangic.AddHours(1);
            this.Size = panel1.Size;



        }

     

       

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randevuEkran = new YeniRandevuEkrani();
            panel1.Controls.Clear();
            panel1.Controls.Add(randevuEkran);
            panel1.Size = randevuEkran.Size;
            this.Size = panel1.Size;
        }

      

        private void KisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            kisiEkleme = new KisiEkle();
            kisiEkleme.Unvani = (Unvan)(sender as ToolStripMenuItem).Tag;
            panel1.Controls.Clear();
            panel1.Controls.Add(kisiEkleme);
            panel1.Size = kisiEkleme.Size;
            this.Size = panel1.Size;
        }

        private void KisiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle= new GuncelleEkran();
            guncelle.unvan = (Unvan)(sender as ToolStripMenuItem).Tag;
            
            panel1.Controls.Clear();
            
            panel1.Controls.Add(guncelle);
            panel1.Size = guncelle.Size;
            this.Size = panel1.Size;

        }


     

     

      
        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IceAktar.Xml();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DısaAktar.Xml();
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IceAktar.Json();
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DısaAktar.Json();
        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printer = new Printer();
            panel1.Controls.Clear();
            panel1.Controls.Add(printer);
        }

        
    }
}
