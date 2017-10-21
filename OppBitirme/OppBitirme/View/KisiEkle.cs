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
    public partial class KisiEkle : UserControl
    {
        public KisiEkle()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KisiEkle_Load(object sender, EventArgs e)
        {
            cmbKisiUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }
    }
}
