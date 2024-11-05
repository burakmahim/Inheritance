using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        // Öğrenci numarası, ad ve soyad bilgilerini konsola yazdıran metot
        public void OgrenciBilgileriYazdir()
        {
            Console.Write($"Öğrenci No: {OgrenciNo}, ");
            Yazdir();  // Base sınıfın Yazdir() metodunu çağırarak ad ve soyadı yazdırıyoruz
        }
    }
}
