﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 22;
            //Her iki şekilde de yazabilirsin bunu 
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Kalem",
                UnitPrice = 13,
                UnitsInStock = 33
            };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

        }
    }
}
