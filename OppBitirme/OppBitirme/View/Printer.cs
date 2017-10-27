using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OppBitirme.Models;

namespace OppBitirme.View
{
    public partial class Printer : UserControl
    {
        public Printer()
        {
            InitializeComponent();
        }
        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

     
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Liste_Doldur.ListeDoldur<Doktor>(Hastane.Doktorlar,listBox1);
            
        }


        private void btnSayfaAyarlari_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //logo için
            e.Graphics.DrawImage(Properties.Resources.logo, 100, 20);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("Randevu Listesi", myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Saat", myFont, sbrush, 140, 328);
            e.Graphics.DrawString("Hasta TCKN", myFont, sbrush, 240, 328);
            e.Graphics.DrawString("Hasta Adı", myFont, sbrush, 440, 328);
            e.Graphics.DrawString("Hasta Soyadı", myFont, sbrush, 640, 328);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

          
            
            foreach (Randevu lvi in listBox2.Items)
            {
                Hasta hasta=Hastane.Hastalar.Where(x => x.Tckn == lvi.hastaTckn).First();
                e.Graphics.DrawString(lvi.Zamani.ToString("dd/MM/yy HH:mm"), myFont, sbrush, 220, y, myStringFormat);
                e.Graphics.DrawString(hasta.Tckn, myFont, sbrush, 340, y, myStringFormat); 
                e.Graphics.DrawString(hasta.Ad, myFont, sbrush, 500, y, myStringFormat);
                e.Graphics.DrawString(hasta.Soyad, myFont, sbrush, 700, y, myStringFormat);

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            



        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Randevu> list = Hastane.Randevular.Where(x=>x?.doktorTckn==(listBox1.SelectedItem as Doktor)?.Tckn).ToList();
            Liste_Doldur.ListeDoldur<Randevu>(list, listBox2);
        }
    }
}
