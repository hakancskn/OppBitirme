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
            Saatlist = Hastane.Randevular.Where(x => x.doktor == this.doktor && x.Zamani.Date == DateTime.Today).Select(x => x.Zamani).ToList();
            DateTime saat = new DateTime();
            saat = DateTime.Today;
            saat=saat.AddHours(9);

            bool varmi;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    varmi = (Saatlist.Where(x => x.Hour == saat.Hour && x.Minute == saat.Minute).Count() > 0 || saat.Hour == 12) ? true : false;


                    tblSaatler.Controls.Add(new Button()
                    {
                        Text = String.Format("{0:t}", saat),
                        Anchor = AnchorStyles.Bottom,
                        AutoSize = true,
                        Tag = saat,
                        BackColor = (varmi) ? Color.Gray : Color.Green,
                        Enabled = !varmi

                    }, j, i);




                    saat = saat.AddMinutes(15);
                }
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
