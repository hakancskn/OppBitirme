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
    public static  class DısaAktar
    {
        
        public static void Xml()
        {
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.Filter = "XML Format | *.xml";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DosyaIslemleri));
                
                using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                {
                 
                        xmlSerializer.Serialize(writer, dosyaIslemleri);
                        
                    
                   
                    writer.Close();
                }
                MessageBox.Show("XML aktarma işlemi başarılı");
            }

        }
        public static void Json()
        {
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
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
                MessageBox.Show("JSON aktarma işlemi başarılı");
            }
        }

     

        }


    
}
