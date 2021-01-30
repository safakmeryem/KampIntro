using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 20;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 23;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.StokAdedi = 34;


            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {

                //Console.WriteLine(product.Adi);
                //Console.WriteLine(product.Fiyati);
                //Console.WriteLine(product.Aciklama);
                //Console.WriteLine(product.StokAdedi);
                //Console.WriteLine("----------------------------------------------");

                Console.WriteLine("----------------------METOTLAR------------------------");

                BasketManager basketManager = new BasketManager();
                basketManager.Ekle(product1);
                basketManager.Ekle(product2);
              






            }






            //Console.WriteLine(product1.Adi);
        }







    }
}
