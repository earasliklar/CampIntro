using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product product1 = new Product();

            product1.ProductName = "elma";
            product1.Price = 15;
            product1.Description = "amasya elması";

            Product product2 = new Product();

            product1.ProductName = "karpuz";
            product1.Price = 17;
            product1.Description = "adana karpuzu";

            Product[] products = new Product[] { product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            BasketManager basketManager = new BasketManager;
            basketManager.Add();
            


        }

    }
}
