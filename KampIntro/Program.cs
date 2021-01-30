using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";

            Console.WriteLine(KategoriEtiketi);



            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.10;

            if (dolarDun> dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else
            {
                Console.WriteLine("Artış butonu");
            }
          

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}




