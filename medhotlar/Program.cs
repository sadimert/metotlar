using System;

namespace medhotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Yeşil Elma";
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Yesil elma;";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Kimdi o kapruz beyaz diyne";
            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }
            //encapsulation
            Console.WriteLine("----------------Metotlar-----------------");
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);


            sepetMenager.Ekle2("armut","yeşil armut",12,10 );
            sepetMenager.Ekle2("elma", "yeşil elma",12,12);
            sepetMenager.Ekle2("karpuz", "diyarbayır karpuzu",12,7 );




        }
    }
}
