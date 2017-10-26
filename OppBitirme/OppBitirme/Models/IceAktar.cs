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
        private static DosyaIslemleri dosyaIslemleri;
        public static void Xml()
        {
             dosyaIslemleri = new DosyaIslemleri();
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
                Yazdir();
            }
        }
        public static void Json()
        {
             dosyaIslemleri = new DosyaIslemleri();
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Filter = "JSON Format | *.json";
          
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader reader = new StreamReader(dosyaAc.FileName))
                {
                    string json = reader.ReadToEnd();
                    dosyaIslemleri= JsonConvert.DeserializeObject<DosyaIslemleri>(json);
                }


                Yazdir();
                
            }
        }
        private static void Yazdir()
        {
            MessageBox.Show($"{dosyaIslemleri.Doktorlar.Count()} Doktor Eklendi\n" +
                     $"{dosyaIslemleri.Hastalar.Count()} Hasta Eklendi\n" +
                     $"{dosyaIslemleri.Hemsireler.Count()} Hemsire Eklendi\n" +
                     $"{dosyaIslemleri.Personeller.Count()} Personel Eklendi\n" +
                       $"{dosyaIslemleri.Randevular.Count()} Randevu Eklendi");
        }
       




    }
}




