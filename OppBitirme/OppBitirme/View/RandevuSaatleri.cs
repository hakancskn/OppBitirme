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
    public partial class RandevuSaatleri : UserControl
    {

        public static int Sutun_sayisi { get; set; }
        private DateTime _secilenSaat=DateTime.MinValue;
        public DateTime SecilenSaat => _secilenSaat;
        public RandevuSaatleri()
        {
            InitializeComponent();
        }

        public Doktor doktor { get; set; } = new Doktor();
        List<DateTime> Saatlist = new List<DateTime>();
        private void RandevuSaatleri_Load(object sender, EventArgs e)
        {

            Saatlist = Hastane.Randevular.Where(x => x?.doktorTckn == this.doktor?.Tckn && x.Zamani.Date == DateTime.Today).Select(x => x.Zamani).ToList();
            DateTime saat = new DateTime();
            saat = DateTime.Today;
            saat = saat.Add(Hastane.AcilisSaati.TimeOfDay);

            bool varmi;
            int i = 0, j = 0;

            while (saat.TimeOfDay < Hastane.KapanisSaati.TimeOfDay)
            {
                varmi = (Saatlist.Where(x => x.TimeOfDay == saat.TimeOfDay).Count() > 0 || (saat.TimeOfDay <= Hastane.PaydosBitis.TimeOfDay &&
                    saat.TimeOfDay >= Hastane.PaydosBaslangic.TimeOfDay) ) ? true : false;//|| saat.TimeOfDay < DateTime.Now.TimeOfDay eklenicek


                tblSaatler.Controls.Add(new Button()
                {
                    Text = String.Format("{0:t}", saat),
                    Anchor = AnchorStyles.Bottom,
                    AutoSize = true,
                    Tag = saat,
                    BackColor = (varmi) ? Color.Gray : Color.Green,
                    Enabled = !varmi

                }, i, j);
                i++;
                if (i >= Sutun_sayisi)
                {
                    i = 0;
                    j++;
                    tblSaatler.ColumnCount++;
                }



                saat = saat.AddMinutes(15);
            }
            foreach (Button item in tblSaatler.Controls)
            {
                item.Click += new EventHandler(Secim_Click);
            }


        }
        private void Secim_Click(object sender, EventArgs e)
        {
            
            foreach (Button item in tblSaatler.Controls)
            {
                item.BackColor = (item.BackColor == Color.YellowGreen )? Color.Green:item.BackColor;
            }

              (sender as Button).BackColor = Color.YellowGreen;
            _secilenSaat = (DateTime)(sender as Button).Tag;
        }

       


    }
}
