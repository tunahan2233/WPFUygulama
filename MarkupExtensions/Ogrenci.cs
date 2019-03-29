using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MarkupExtensions
{
    public class Ogrenci : MarkupExtension
    {
        public string OgrenciAdi { get; set; }
        public int OgrenciNot { get; set; }
        public Ogrenci()
        {
           
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Sonuc : {OgrenciNot * 2}";
        }
    }
}
