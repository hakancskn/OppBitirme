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
    public partial class YeniRandevuEkrani : UserControl
    {
        public YeniRandevuEkrani()
        {
            InitializeComponent();
        }

        private void YeniRandevuEkrani_Load(object sender, EventArgs e)
        {

            List<Hasta> hasta = Hastane.Hastalar;

            hasta.ForEach(a =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = a.Ad;
                li.SubItems.Add(a.Soyad);
                li.SubItems.Add(a.Tckn);
                li.Tag = a;
                lstHasta.Items.Add(li);
            });
            cmbServisler.DataSource = Enum.GetValues(typeof(Hastane.Servisler));

        }

        private void lstHasta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.DataSource = null;
            cmbDoktorlar.DisplayMember = "AdSoyad";
            cmbDoktorlar.DataSource = Hastane.Doktorlar.Where(x => x.Servis == (Hastane.Servisler)cmbServisler.SelectedItem).ToList();

        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                pnlSaatler.Controls.Clear();

            }
            else
            {
                pnlSaatler.Controls.Clear();
                RandevuSaatleri randevuSaatleri = new RandevuSaatleri();
                randevuSaatleri.doktor = (Doktor)cmbDoktorlar.SelectedItem;
                randevuSaatleri.Size = pnlSaatler.Size - (new Size(5, 5));
                pnlSaatler.Controls.Add(randevuSaatleri);

            }


        }
    }
}
