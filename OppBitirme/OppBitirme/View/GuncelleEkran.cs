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
using OppBitirme.Interfaces;

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
            cmbHastaCinsiyeti.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));

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
                    chlsHemsire.Visible = false;
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
                    chlsHemsire.Visible = false;
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
                    chlsHemsire.Visible = true;


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
                    chlsHemsire.Visible = false;
                    break;
                default:
                    break;
            }
        }
        Kisi SeciliKisi;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliKisi = (Kisi)(listView1.FocusedItem.Tag);
            txtHastaAdi.Text = SeciliKisi.Ad;
            txtHastaSoyadi.Text = SeciliKisi.Soyad;
            txtHastaTckn.Text = SeciliKisi.Tckn;
            txtHastaTel.Text = SeciliKisi.Telefon;
            txtHastaAdres.Text = SeciliKisi.Adres;
            txtHastaMail.Text = SeciliKisi.Mail;
            //dtpHastaDogumTarihi.Value = kisi.DogumTarihi;
            cmbHastaCinsiyeti.SelectedItem = SeciliKisi.cinsiyet;
            if (SeciliKisi is IServis)
            {
                cmbKisiBrans.SelectedItem = (SeciliKisi as IServis).Servis;
            }
            if (SeciliKisi is Doktor)
            {
                chlsHemsire.DataSource = null;

                Doktor dkt = (Doktor)listView1.FocusedItem?.Tag;

                chlsHemsire.DataSource = dkt?.Hemsireleri;
                chlsHemsire.DisplayMember = "AdSoyad";

            }
            if (SeciliKisi is IBrans)
            {
                cmbKisiBrans.SelectedItem = (SeciliKisi as IBrans).branslar;
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {





            if (SeciliKisi == null)
            {
                MessageBox.Show("Neyi Güncelliyim");
                return;
            }




            if (SeciliKisi.Ad == txtHastaAdi.Text && SeciliKisi.Soyad == txtHastaSoyadi.Text &&
                SeciliKisi.Tckn == txtHastaTckn.Text)
            {
                MessageBox.Show("değişiklik yapmadınız");
            }

            else // (cevap == DialogResult.Yes) 

            {
                try
                {
                    listView1.SelectedItems[0].SubItems[0].Text = txtHastaAdi.Text;
                    listView1.SelectedItems[0].SubItems[1].Text = txtHastaSoyadi.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = cmbHastaCinsiyeti.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = txtHastaTckn.Text;
                    listView1.SelectedItems[0].SubItems[4].Text = txtHastaAdres.Text;
                    listView1.SelectedItems[0].SubItems[5].Text = txtHastaMail.Text;
                    listView1.SelectedItems[0].SubItems[6].Text = txtHastaTel.Text;
                    listView1.SelectedItems[0].SubItems[6].Text = cmbKisiBrans.Text;
                    listView1.SelectedItems[0].SubItems[7].Text = dtpHastaDogumTarihi.Text;



                }
                catch (Exception)
                {

                }
                DialogResult cevap = MessageBox.Show($"{SeciliKisi.Ad} adlı kişiyi güncellemek istiyor musunuz ?", "kişi güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        SeciliKisi.Ad = txtHastaAdi.Text;
                        SeciliKisi.Soyad = txtHastaSoyadi.Text;
                        SeciliKisi.Tckn = txtHastaTckn.Text;
                        SeciliKisi.Telefon = txtHastaTel.Text;
                        SeciliKisi.Mail = txtHastaMail.Text;
                        SeciliKisi.DogumTarihi = dtpHastaDogumTarihi.Value;
                        SeciliKisi.cinsiyet = (Cinsiyet)cmbHastaCinsiyeti.SelectedItem;
                        if (SeciliKisi is IBrans)
                        {
                            (SeciliKisi as IBrans).branslar = (Hastane.Branslar)cmbKisiBrans.SelectedItem;
                        }
                        if (SeciliKisi is IServis)
                        {
                            (SeciliKisi as IServis).Servis = (Hastane.Servisler)cmbKisiBrans.SelectedItem;
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Güncelleme Başarılı");
                    }
                }


            }

        }

        private void cmbKisiBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



