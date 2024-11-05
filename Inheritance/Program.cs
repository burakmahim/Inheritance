using Inheritance;

// Örnek bir öğrenci nesnesi oluşturma ve özelliklerini atama
Ogrenci ogrenci = new Ogrenci()
{
    Ad = "Ahmet",
    Soyad = "Yılmaz",
    OgrenciNo = 12345
};

// Örnek bir öğretmen nesnesi oluşturma ve özelliklerini atama
Ogretmen ogretmen = new Ogretmen()
{
    Ad = "Ayşe",
    Soyad = "Demir",
    Maas = 5000m
};

// Öğrenci ve öğretmen bilgilerini ekrana yazdırma
Console.WriteLine("Öğrenci Bilgileri:");
ogrenci.OgrenciBilgileriYazdir();

Console.WriteLine("\nÖğretmen Bilgileri:");
ogretmen.OgretmenBilgileriYazdir();