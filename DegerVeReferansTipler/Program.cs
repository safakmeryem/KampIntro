using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // buna göre sayi1 nedir--Cevap:30 çünkü sayi 1 i sayi 2 ye eşitledik. sayi1 = 30 oldu.
            //Değeri atadı sayi2 ile işi bitti bunun. 
            //sonra sayi 2 yi 65 dedik. ama bu bizi etkilemiyor. Sayi 1 hala 30
            Console.WriteLine(sayi1);
            Console.WriteLine("----------------------------------------------------------------");

            int[] sayilar1 = new int[] { 10, 15, 20, 25 };
            int[] sayilar2 = new int[] { 60, 70, 80, 90 };
            sayilar1 = sayilar2;
            sayilar2[0] = 888;
            //sayilar1[0] elemanı kaçtır---Cevap:888
            // çünkü arraylar referans tipidir ve bunu bir seye eşitlediğinde diğer tarafta düşer bunun değerleri
            //eşitlendiği değerleri alır. Bu değerler değişirse de yine onları görmeye devam eder...
            Console.WriteLine(sayilar1[0]);




        }
    }
}
