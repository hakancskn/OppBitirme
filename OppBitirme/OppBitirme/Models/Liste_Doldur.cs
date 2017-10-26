using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OppBitirme.Models
{
    public class Liste_Doldur
    {
        public static void ListeDoldur<T>(List<T> list,ListBox listBox)
        {
            listBox.Items.Clear();
            
                list.ForEach(a =>
                {
                    listBox.Items.Add(a);
                });

        }
    }
}
