using System;

namespace _04.Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Price list in BGN
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());

            // Kilograms
            int vegetablesKilograms = int.Parse(Console.ReadLine());
            int fruitsKilograms = int.Parse(Console.ReadLine());

            // Calculating the holl price in BGN
            double priceForVegetables = vegetablesPrice * vegetablesKilograms;
            double priceForFruits = fruitsPrice * fruitsKilograms;
            double price = priceForVegetables + priceForFruits;

            // Price in EUR
            price = price / 1.94;

            Console.WriteLine($"{price:f2}");
        }
    }
}
