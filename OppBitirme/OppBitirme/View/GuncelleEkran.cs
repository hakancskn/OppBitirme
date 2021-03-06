﻿using System;
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
using static System.Windows.Forms.ComboBox;
using static OppBitirme.Models.Hastane;

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
            Form_Yenile();
        }

        Kisi SeciliKisi;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control_Doldur();
          
        }
        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            if (SeciliKisi == null)
            {
                MessageBox.Show("Güncellenecek Kişiyi Seçiniz.");
                return;
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
                    SeciliKisi.cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbHastaCinsiyeti.SelectedItem.ToString());
                    
                    if (SeciliKisi is IBrans)
                    {
                        (SeciliKisi as IBrans).brans = (Hastane.Branslar)cmbKisiBrans.SelectedItem;
                    }
                    if (SeciliKisi is IServis)
                    {
                        (SeciliKisi as IServis).Servis = (Hastane.Servisler)cmbKisiBrans.SelectedItem;
                    }
                    if (SeciliKisi is Doktor)
                    {

                        foreach (Hemsire item in chlsDktHemsire.Items)
                        {

                            item.DoktorTckn = ((Doktor)SeciliKisi).Tckn;
                            item.Servis = (Hastane.Servisler)cmbKisiBrans.SelectedItem;
                        }
                        foreach (Hemsire item in chlBosHemsire.Items)
                        {
                            item.DoktorTckn = null;
                        }

                    }

                    Form_Yenile();
                    
              
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }





            }

        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (chlBosHemsire.CheckedItems.Count > 0)
                for (int i = 0; i < chlBosHemsire.CheckedItems.Count; i++)
                {
                    chlsDktHemsire.Items.Add(chlBosHemsire.CheckedItems[i]);
                    chlBosHemsire.Items.Remove(chlBosHemsire.CheckedItems[i]);

                }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < chlsDktHemsire.CheckedItems.Count; i++)
            {
                chlBosHemsire.Items.Add(chlsDktHemsire.CheckedItems[i]);
                chlsDktHemsire.Items.Remove(chlsDktHemsire.CheckedItems[i]);

            }

        }

        private void Form_Yenile()
        {
            listView1.Items.Clear();
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
                    pnlHemsire.Visible = false;
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
                    pnlHemsire.Visible = false;
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
                    pnlHemsire.Visible = true;


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
                    cmbKisiBrans.DataSource = null;
                    panel1.Visible = true;
                    lblBrans.Text = "Servis";
                    cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));
                    pnlHemsire.Visible = false;
                    break;
                default:
                    break;
            }


        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null)
            {
                MessageBox.Show("Silinecek Kişiyi Seçiniz.");
                return;
            }
            else
            {
                switch (unvan)
                {
                    case Unvan.Hasta:
                        Hastane.Hastalar.Remove((Hasta)listView1.FocusedItem.Tag);
                        break;
                    case Unvan.Personel:
                        Hastane.Personeller.Remove((Personel)listView1.FocusedItem.Tag);
                        break;
                    case Unvan.Doktor:
                        Hastane.Doktorlar.Remove((Doktor)listView1.FocusedItem.Tag);
                        break;
                    case Unvan.Hemşire:
                        Hastane.Hemsireler.Remove((Hemsire)listView1.FocusedItem.Tag);
                        break;
                    default:
                        break;
                }
               
                MessageBox.Show("Kişi Silindi");
               
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            
            string arama = txtArama.Text.ToLower();
            switch (unvan)
            {
                case Unvan.Hasta:
                    List<Hasta> hastalst ;
                    hastalst = Hastane.Hastalar.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.Contains(arama) || x.Tckn.Contains(arama)).ToList();
                   hastalst.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });

                    
                    break;
                case Unvan.Personel:
                    List<Personel> prslst;
                    prslst = Hastane.Personeller.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.Contains(arama) || x.Tckn.Contains(arama)).ToList();
                    prslst.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });

                    break;
                case Unvan.Doktor:
                    List<Doktor> dktlst;
                    dktlst = Hastane.Doktorlar.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.Contains(arama) || x.Tckn.Contains(arama)).ToList();
                    dktlst.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });

                    break;
                case Unvan.Hemşire:
                    List<Hemsire> hmslst;
                    hmslst = Hastane.Hemsireler.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.Contains(arama) || x.Tckn.Contains(arama)).ToList();
                    hmslst.ForEach(a =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = a.Ad;
                        li.SubItems.Add(a.Soyad);
                        li.SubItems.Add(a.Tckn);
                        li.Tag = a;
                        listView1.Items.Add(li);
                    });

                    break;
                default:
                    break;
            }
           
            
               
       
        }
        private void Control_Doldur()
        {
            SeciliKisi = (Kisi)(listView1.FocusedItem.Tag);

            txtHastaAdi.Text = SeciliKisi.Ad;
            txtHastaSoyadi.Text = SeciliKisi.Soyad;
            txtHastaTckn.Text = SeciliKisi.Tckn;
            txtHastaTel.Text = SeciliKisi.Telefon;
            txtHastaAdres.Text = SeciliKisi.Adres;
            txtHastaMail.Text = SeciliKisi.Mail;
            dtpHastaDogumTarihi.Value = SeciliKisi.DogumTarihi;
            cmbHastaCinsiyeti.SelectedIndex = cmbHastaCinsiyeti.Items.IndexOf(SeciliKisi.cinsiyet.ToString());

            if (SeciliKisi is IServis)
            {
                cmbKisiBrans.SelectedItem = (SeciliKisi as IServis).Servis;
            }
            if (SeciliKisi is Doktor)
            {
                Doktor dkt = (Doktor)SeciliKisi;
                List<Hemsire> BosHemsireler = new List<Hemsire>();
                chlsDktHemsire.Items.Clear();
                chlBosHemsire.Items.Clear();
                List<Hemsire> DktHemsireleri = Hastane.Hemsireler.Where(x => x?.DoktorTckn == dkt.Tckn).ToList();

                DktHemsireleri.ForEach(c =>
                {
                    chlsDktHemsire.Items.Add(c);

                });
                BosHemsireler = Hastane.Hemsireler.Where(x => x.Servis == dkt.Servis && x.DoktorTckn== null).ToList();

                BosHemsireler.ForEach(bos =>
                {
                    chlBosHemsire.Items.Add(bos);
                });

            }
            if (SeciliKisi is IBrans)
            {
                cmbKisiBrans.SelectedItem = (SeciliKisi as IBrans).brans;
            }

        }


       

    }
}



