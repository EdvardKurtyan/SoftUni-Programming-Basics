using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            TotalPrice(product, price, quantity);
        }

        private static void TotalPrice(string item, double price, int quantity)
        {
            switch (item)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "cake":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            //price *= quantity;
            double totalPrice = price * quantity;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
