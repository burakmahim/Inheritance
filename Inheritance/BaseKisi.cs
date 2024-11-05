using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Ad ve Soyad bilgilerini konsola yazdıran metot
        public void Yazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }
}
