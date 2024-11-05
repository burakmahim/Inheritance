using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        // Maaş bilgisi, ad ve soyad bilgilerini konsola yazdıran metot
        public void OgretmenBilgileriYazdir()
        {
            Console.Write($"Maaş: {Maas}, ");
            Yazdir();  // Base sınıfın Yazdir() metodunu çağırarak ad ve soyadı yazdırıyoruz
        }
    }
}
