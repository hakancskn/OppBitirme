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
        public RandevuSaatleri()
        {
            InitializeComponent();
        }

        public Doktor doktor { get; set; } = new Doktor();
        List<DateTime> Saatlist = new List<DateTime>();
        private void RandevuSaatleri_Load(object sender, EventArgs e)
        {
            Saatlist = Hastane.Randevular.Where(x => x.doktor == this.doktor && x.Zamani == DateTime.Today).Select(x => x.Zamani).ToList();
            DateTime saat = new DateTime();
            saat = DateTime.Today;
            saat.AddHours(9);

            int varmi;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    varmi = Saatlist.Where(x => x.Hour == saat.Hour && x.Minute == saat.Minute).Count();
                    if (saat.Hour < 12 && saat.Hour > 13) ;
                    else { 
                        tblSaatler.Controls.Add(new Button()
                        {
                            Text = saat.TimeOfDay.ToString(),
                            Anchor = AnchorStyles.Left,
                            AutoSize = true,
                            Tag = saat,
                            BackColor=(varmi > 0) ? Color.Green : Color.Gray

                        }, i, j);

                    }
                   

                    saat.AddMinutes(15);
                }
            }

        }
        private void Secim_Click(object sender, EventArgs e)
        {


        }


    }
}
