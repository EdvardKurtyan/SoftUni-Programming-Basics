using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>();
            var productsQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "buy") break;
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, price);
                    productsQuantity.Add(product, quantity);
                }
                else if (products.ContainsKey(product))
                {
                    products.Remove(product);
                    products.Add(product, price);
                    productsQuantity[product] += quantity;
                }
            }
            foreach (var product in products)
            {
                foreach (var item in productsQuantity)
                {
                    if (product.Key == item.Key)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value * item.Value:f2}");
                    }
                }
            }
        }
    }
}
