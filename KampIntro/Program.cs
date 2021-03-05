using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarBugun = 7.70;
            double dolarDun = 7.60;
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artıs oku");
            }
            else if (true)
            {
                Console.WriteLine("Azalıs oku");
            }
            else
            {
                Console.WriteLine("Degismedi");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
