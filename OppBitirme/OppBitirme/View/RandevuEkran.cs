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
        }
    }
}
