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
    public partial class GuncelleEkran : UserControl
    {
        public Unvan unvan { get; set; }
        public GuncelleEkran()
        {
            InitializeComponent();
        }
   

        private void GuncelleEkrani_Load(object sender, EventArgs e)
        {
            
            switch (unvan)
            {

                case Unvan.Hasta:
                    Hastane.Hastalar.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.cinsiyet.ToString());
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });
                    cmbKisiBrans.DataSource = null;
                    panel1.Visible = false;
                    break;
                case Unvan.Personel:
                    Hastane.Personeller.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.cinsiyet.ToString());
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });
                    cmbKisiBrans.DataSource = null;
                    panel1.Visible = true;
                    lblBrans.Text = "Branş";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Branslar));
                    break;
                case Unvan.Doktor:
                    Hastane.Doktorlar.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.cinsiyet.ToString());

                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });
                    cmbKisiBrans.DataSource = null;
                    panel1.Visible = true;
                    lblBrans.Text = "Servis";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));

                    break;
                case Unvan.Hemşire:
                    Hastane.Hemsireler.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.cinsiyet.ToString());

                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });
                    break;
                default:
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi kisi = (Kisi)(listView1.FocusedItem.Tag);
            txtHastaAdi.Text = kisi.Ad; 
            txtHastaSoyadi.Text = kisi.Soyad;
            txtHastaTckn.Text = kisi.Tckn;
            txtHastaTel.Text = kisi.Telefon;
            txtHastaAdres.Text = kisi.Adres;
            txtHastaMail.Text = kisi.Mail;
            //dtpHastaDogumTarihi.Value = kisi.DogumTarihi;
            cmbHastaCinsiyeti.SelectedItem = kisi.cinsiyet;
            

        }
    }
}