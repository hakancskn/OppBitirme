using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OppBitirme.Models.Kisi;

namespace OppBitirme.View
{
    public partial class GuncelleEkran : UserControl
    {
        public GuncelleEkran()
        {
            InitializeComponent();
        }
        public GuncelleEkran(Unvan unvani)
        {
            InitializeComponent();

        }

        private void HastaEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}