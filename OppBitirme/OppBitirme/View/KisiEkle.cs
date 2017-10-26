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
using static OppBitirme.Models.Hastane;

namespace OppBitirme.View
{
    public partial class KisiEkle : UserControl
    {

        public Kisi.Unvan Unvani { get; set; }
        public KisiEkle()
        {
            InitializeComponent();
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
                    unvan = Unvani
                };

                switch (yeniKisi.unvan)
                {
                    case Unvan.Hasta:
                        Hasta hasta = new Hasta();
                        hasta.Cast(yeniKisi);
                        Hastane.Hastalar.Add(hasta);
                        break;
                    case Unvan.Personel:
                        Personel personel = new Personel();
                        personel.Cast(yeniKisi);
                        personel.brans = (Branslar)cmbKisiBrans.SelectedItem;
                        Hastane.Personeller.Add(personel);
                        break;
                    case Unvan.Doktor:
                        Doktor doktor = new Doktor();
                        doktor.Cast(yeniKisi);
                        doktor.Servis = (Servisler)cmbKisiBrans.SelectedItem;
                        for (int i = 0; i < chlsHemsire.CheckedItems.Count; i++)
                        {
                            Hemsire bsHemsire = (Hemsire)chlsHemsire.CheckedItems[i];
                            doktor.Hemsireleri.Add(bsHemsire);
                            bsHemsire.Doktoru = doktor;
                            
                        }
                        Hastane.Doktorlar.Add(doktor);

                            break;
                    case Unvan.Hemşire:
                        Hemsire hemsire = new Hemsire();
                        hemsire.Cast(yeniKisi);
                        hemsire.Servis = (Servisler)cmbKisiBrans.SelectedItem;
                        Hastane.Hemsireler.Add(hemsire);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Kaydınız alınmıştır.");
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
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is CheckedListBox)
                    (item as CheckedListBox).Items.Clear();
            }

        }


        private void KisiEkle_Load_1(object sender, EventArgs e)
        {
            cmbKisiCinsiyet.DataSource=(Enum.GetNames(typeof(Cinsiyet)));
            
            switch (Unvani)
            {
                case Unvan.Doktor:
                    cmbKisiBrans.DataSource = null;
                    pnlBrans.Visible = true;
                    lblBrans.Text = "Servis";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));

                    chlsHemsire.Visible = true;
                    
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



    

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void cmbKisiBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            chlsHemsire.Items.Clear();
            if (Unvani == Unvan.Doktor)
            {
                List<Hemsire> BosHemsireLer= Hemsireler.Where(x => x.Doktoru == null && x.Servis
                                            == (Servisler)cmbKisiBrans.SelectedItem).ToList();

                foreach (Hemsire item in BosHemsireLer)
                {
                    chlsHemsire.Items.Add(item);

                }

                
            }

        }
    }
}
