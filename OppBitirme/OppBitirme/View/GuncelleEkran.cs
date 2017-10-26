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
            Form_Temizle();
        }

        Kisi SeciliKisi;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SeciliKisi = (Kisi)(listView1.FocusedItem.Tag);
            int a = cmbHastaCinsiyeti.Items.IndexOf(SeciliKisi.cinsiyet.ToString());
            txtHastaAdi.Text = SeciliKisi.Ad;
            txtHastaSoyadi.Text = SeciliKisi.Soyad;
            txtHastaTckn.Text = SeciliKisi.Tckn;
            txtHastaTel.Text = SeciliKisi.Telefon;
            txtHastaAdres.Text = SeciliKisi.Adres;
            txtHastaMail.Text = SeciliKisi.Mail;
            dtpHastaDogumTarihi.Value = SeciliKisi.DogumTarihi;
            cmbHastaCinsiyeti.SelectedIndex = a;
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
                List<Hemsire> DktHemsireleri= Hastane.Hemsireler.Where(x => x.Doktoru?.Tckn == dkt.Tckn).ToList();

                 DktHemsireleri.ForEach(c =>
               {
                   chlsDktHemsire.Items.Add(c);

               });
                BosHemsireler = Hastane.Hemsireler.Where(x => x.Servis == dkt.Servis && x.Doktoru == null).ToList();

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            if (SeciliKisi == null)
            {
                MessageBox.Show("Neyi Güncelliyim");
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

                            item.Doktoru = (Doktor)SeciliKisi;
                            item.Servis = (Hastane.Servisler)cmbKisiBrans.SelectedItem;
                        }
                        foreach (Hemsire item in chlBosHemsire.Items)
                        {
                            item.Doktoru = null;
                        }

                    }

                    Form_Temizle();
                    //cmbKisiBrans.DataSource = null;
                    //panel1.Visible = true;
                    //lblBrans.Text = "Servis";
                    //cmbKisiBrans.DataSource = Enum.GetValues(typeof(Hastane.Servisler));
                    //pnlHemsire.Visible = true;



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

        private void Form_Temizle()
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
                    List<Hasta> hastalst = new List<Hasta>();
                    Arama.ListedeArama<Hasta>(arama, ref hastalst);
                    ListeyiDoldur(hastalst);
                    break;
                case Unvan.Personel:
                     List<Personel> PersonelLst = new List<Personel>();
                    Arama.ListedeArama<Personel>(arama, ref PersonelLst);
                    ListeyiDoldur(PersonelLst);

                    break;
                case Unvan.Doktor:
                    List<Doktor> Doktorlst = new List<Doktor>();
                    Arama.ListedeArama<Doktor>(arama, ref Doktorlst);
                    ListeyiDoldur(Doktorlst);

                    break;
                case Unvan.Hemşire:
                    List<Hemsire> Hemsirelst = new List<Hemsire>();

                    Arama.ListedeArama<Hemsire>(arama, ref Hemsirelst);
                    ListeyiDoldur(Hemsirelst);

                    break;
                default:
                    break;
            }
           
            
               
       
        }
        private void ListeyiDoldur<T>(List<T> list)
        {
            listView1.Items.Clear();
            if(list is List<Hasta>)
            {
                (list as List<Hasta>).ForEach(a =>
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = a.Ad;
                    li.SubItems.Add(a.Soyad);
                    li.SubItems.Add(a.Tckn);
                    li.Tag = a;
                    listView1.Items.Add(li);
                });

            }else if (list is List<Hemsire>)
            {
                (list as List<Hemsire>).ForEach(a =>
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = a.Ad;
                    li.SubItems.Add(a.Soyad);
                    li.SubItems.Add(a.Tckn);
                    li.Tag = a;
                    listView1.Items.Add(li);
                });

            }
            else if (list is List<Doktor>)
            {
                (list as List<Doktor>).ForEach(a =>
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = a.Ad;
                    li.SubItems.Add(a.Soyad);
                    li.SubItems.Add(a.Tckn);
                    li.Tag = a;
                    listView1.Items.Add(li);
                });

            }
            else if (list is List<Personel>)
            {
                (list as List<Personel>).ForEach(a =>
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = a.Ad;
                    li.SubItems.Add(a.Soyad);
                    li.SubItems.Add(a.Tckn);
                    li.Tag = a;
                    listView1.Items.Add(li);
                });

            }



        }

    }
}



