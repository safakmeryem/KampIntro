using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Ali", "Aslı", "Yeliz" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            // YENİ BİR ELEMAN eklemek için böyle bir sey yapamazsın
            //Çünkü burası bir array ve sayısı belirli sonradan ekleme yapamazsın
            //Sonradan eklemek için koleksiyonları-generic listi- kullanacaksın
            //isimler[4] = "İlke";
            //Console.WriteLine(isimler[4]);
            Console.WriteLine("-------------------------------------------------------");


            List<string> isimler2 = new List<string> { "Engin", "Ali", "Aslı", "Yeliz" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Eylül");
            Console.WriteLine("---------------yeni eklenen bu--------");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[1]);




        }
    }
}
