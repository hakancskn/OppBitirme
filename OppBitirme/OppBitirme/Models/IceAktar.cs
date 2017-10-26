using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OppBitirme.Models
{
    public class IceAktar
    {
        public static void Xml()
        {
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Bir Kisi XML dosyasını seçiniz";
            dosyaAc.Filter = "XML Format | *.xml";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DosyaIslemleri));
                using (TextReader reader = new StreamReader(dosyaAc.FileName))
                {
                    //kisiler = (List<Kisi>)xmlSerializer.Deserialize(reader);
                    dosyaIslemleri = xmlSerializer.Deserialize(reader) as DosyaIslemleri;
                    reader.Close();

                  

                }
                MessageBox.Show($"{dosyaIslemleri.Doktorlar.Count()} Doktor Eklendi\n" +
                      $"{dosyaIslemleri.Hastalar.Count()} Hasta Eklendi\n" +
                      $"{dosyaIslemleri.Hemsireler.Count()} Hemsire Eklendi\n" +
                      $"{dosyaIslemleri.Personeller.Count()} Personel Eklendi");
            }
        }
        public static void Json()
        {
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            OpenFileDialog dosyaKaydet = new OpenFileDialog();
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.Filter = "JSON Format | *.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(dosyaIslemleri);
                using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                {
                    writer.Write(json);
                    writer.Close();
                }
                MessageBox.Show($"{dosyaIslemleri.Doktorlar.Count()} Doktor Eklendi\n" +
                     $"{dosyaIslemleri.Hastalar.Count()} Hasta Eklendi\n" +
                     $"{dosyaIslemleri.Hemsireler.Count()} Hemsire Eklendi\n" +
                     $"{dosyaIslemleri.Personeller.Count()} Personel Eklendi");
            }
        }
       




    }
}




