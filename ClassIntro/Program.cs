using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Eren";
            int yas = 20;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlemeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlemeOrani = 64; 

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlemeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }


    }
}
