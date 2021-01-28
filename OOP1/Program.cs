using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //üstteki ve alttaki aynı şeydir iki türlü de kayıt yapılır.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.add();
            
        }
    }
}
