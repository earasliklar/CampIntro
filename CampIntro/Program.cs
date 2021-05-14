using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.name = "Laptop";

            Product product2 = new Product();

            product2.id = 2;
            product2.name = "ekran kartı";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.id+" "+product.name);
            }
        
        }
        class Product
        {
            public int id { get; set; }
            public string name { get; set; }


        }
    }
}
