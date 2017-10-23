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
    public class Hastane
    {
        public static List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public static List<Personel> Personeller { get; set; } = new List<Personel>();
        public static List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public static List<Hasta> Hastalar { get; set; } = new List<Hasta>();

        public static List<Randevu> Randevular { get; set; } = new List<Randevu>();

        public enum Servisler
        {
            das

        }
        public enum Branslar
        {
dsa
        }


        SaveFileDialog dosyaKaydet = new SaveFileDialog();
        public void xml()
        {
            
            
            dosyaKaydet.Filter = "XML Format | *.xml";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Hastane));
                using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                {
                    xmlSerializer.Serialize(writer, this);
                    writer.Close();
                }
                MessageBox.Show("XML aktarma işlemi başarılı");
            }
        }


    }
}
