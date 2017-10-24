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
using OppBitirme.Models;

namespace OppBitirme.View
{
    public partial class KisiEkle : UserControl
    {
        private object ex;

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
            try
            {
                Kisi yeniKisi = new Kisi
                {
                    Ad = txtKisiAd.Text,
                    Soyad = txtKisiSoyad.Text,
                    Tckn = txtKisiTckn.Text,
                    cinsiyet = (Cinsiyet)Enum.Parse((typeof(Cinsiyet)),
                                        cmbKisiCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpKisiDogumTarihi.Value,
                    Telefon = mtxtTel.Text,
                    Mail = txtKisiMail.Text,
                    Adres = txtKisiAdres.Text,
                    unvan = (Unvan)Enum.Parse((typeof(Unvan)),
                                        cmbKisiUnvan.SelectedItem.ToString()),
                };

                switch (yeniKisi.unvan)
                {
                    case Unvan.Hasta:
                        Hastane.Hastalar.Add((Hasta)yeniKisi);
                        break;
                    case Unvan.Personel:
                        Hastane.Personeller.Add((Personel)yeniKisi);
                        break;
                    case Unvan.Doktor:
                        (yeniKisi as Doktor).Servis = (Hastane.Servisler)cmbKisiBrans.SelectedItem;
                        Doktor doktor = (Doktor)yeniKisi;
                       
                        Hastane.Doktorlar.Add(doktor);
                        break;
                    case Unvan.Hemşire:
                        Hastane.Hemsireler.Add((Hemsire)yeniKisi);
                        break;
                    default:
                        break;
                }

                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
                    
        }
        void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is PictureBox)
                    (item as PictureBox).Image = Properties.Resources.user_add;
            }

        }
        

        private void KisiEkle_Load_1(object sender, EventArgs e)
        {
            cmbKisiUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
            cmbKisiCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));

            chlsHemsire.Visible = false;
        }

        private void cmbKisiUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Unvan)cmbKisiUnvan.SelectedIndex)
            {
                case Unvan.Doktor:
                    cmbKisiBrans.DataSource = null;
                    pnlBrans.Visible = true;
                    lblBrans.Text = "Servis";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));

                    chlsHemsire.Visible = true;
                    
                    if (cmbKisiBrans.SelectedIndex != -1)
                    {
                        chlsHemsire.DataSource = null;
                        chlsHemsire.DataSource = Hastane.Hemsireler.Where(x => x.Servis == (Hastane.Servisler)cmbKisiBrans.SelectedItem && x.Doktoru == null).ToList();
                        chlsHemsire.DisplayMember = "AdSoyad";
                    }
                   
                    break;
                case Unvan.Hemşire:
                    cmbKisiBrans.DataSource = null;
                    pnlBrans.Visible = true;
                    lblBrans.Text = "Servis";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));
                    chlsHemsire.Visible = false;
                    break;
                case Unvan.Hasta:
                    cmbKisiBrans.DataSource = null;
                    pnlBrans.Visible = false;
                    chlsHemsire.Visible = false;
                    break;
                case Unvan.Personel:
                    cmbKisiBrans.DataSource = null;
                    pnlBrans.Visible = true;
                    lblBrans.Text = "Branş";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Branslar));
                    chlsHemsire.Visible = false;
                    break;
                default:
                    pnlBrans.Visible = false;
                    chlsHemsire.Visible = false;
                    break;

            }

           
           
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbKisiBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void chlsHemsire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
