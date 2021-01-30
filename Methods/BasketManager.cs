using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Ürün sepete Eklendi:"  + product.Adi);
        }
    }
}
