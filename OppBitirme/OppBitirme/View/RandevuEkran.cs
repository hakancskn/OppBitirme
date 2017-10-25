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
        Hasta SecilenHasta = new Hasta();
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
            cmbServisler.SelectedIndex = -1;
        }

        private void lstHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (lstHasta.FocusedItem != null)
            {
                SecilenHasta = (Hasta)lstHasta.FocusedItem.Tag;
                List<Randevu> list = Hastane.Randevular.Where(x => x.hasta == SecilenHasta).ToList();
                lstRandevu.Items.Clear();
                list.ForEach(a =>
                {
                   
                    ListViewItem li = new ListViewItem();
                    li.Text = a.Servisi.ToString();
                    li.SubItems.Add(a.doktor.AdSoyad);
                    li.SubItems.Add(a.Zamani.ToString("dd/MM/yy HH:mm"));
                    li.Tag = a;
                    lstRandevu.Items.Add(li);
                });
            }
            cmbServisler.SelectedIndex = -1;
        }

        private void cmbServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServisler.SelectedIndex != -1)
            {
                cmbDoktorlar.DataSource = null;
                cmbDoktorlar.DisplayMember = "AdSoyad";
                cmbDoktorlar.DataSource = Hastane.Doktorlar.Where(x => x.Servis == (Hastane.Servisler)cmbServisler.SelectedItem).ToList();
            }
            else
            {
                cmbDoktorlar.DataSource=null;
            }
        }
        RandevuSaatleri randevuSaatleri;
        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                pnlSaatler.Controls.Clear();

            }
            else
            {
                pnlSaatler.Controls.Clear();
                randevuSaatleri= new RandevuSaatleri();
                randevuSaatleri.doktor = (Doktor)cmbDoktorlar.SelectedItem;
                randevuSaatleri.Size = pnlSaatler.Size - (new Size(5, 5));
                pnlSaatler.Controls.Add(randevuSaatleri);

            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hasta Khasta = new Hasta();
            Khasta = (Hasta)lstHasta.FocusedItem.Tag;
            if (randevuSaatleri.SecilenSaat != DateTime.MinValue)
            {
                if(0<Hastane.Randevular.Where(x => x.hasta == SecilenHasta && x.Zamani == randevuSaatleri.SecilenSaat).Count())
                    MessageBox.Show("Zaten Bu Saatte Bir Randevunuz Var." );
                else
                {
                    Randevu Yenirandevu = new Randevu()
                    {
                        Zamani = randevuSaatleri.SecilenSaat,
                        Servisi = (Hastane.Servisler)Enum.Parse((typeof(Hastane.Servisler)),
                                        cmbServisler.SelectedItem.ToString()),
                        doktor = (Doktor)cmbDoktorlar.SelectedValue,
                        hasta = Khasta

                };
                    Hastane.Randevular.Add(Yenirandevu);
                    MessageBox.Show("Randevu Eklendi");
                    cmbServisler.SelectedIndex = -1;
                    


                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Saat Seçiniz.");
            }
        }

        
    }
}
