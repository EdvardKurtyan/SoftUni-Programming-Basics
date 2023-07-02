using System;

namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //      град / продукт  coffee   water   beer    sweets  peanuts
            //      Sofia            0.50    0.80    1.20    1.45    1.60
            //      Plovdiv          0.40    0.70    1.15    1.30    1.50
            //      Varna            0.45    0.70    1.10    1.35    1.55
            double price = 0;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = 0.5;
                }
                else if (city == "Plovdiv")
                {
                    price = 0.4;

                }
                else if (city == "Varna")
                {
                    price = 0.45;
                }
            }
            //           ---------------------------------------------------------
            if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = 0.8;
                }
                else if (city == "Plovdiv")
                {
                    price = 0.7;

                }
                else if (city == "Varna")
                {
                    price = 0.7;
                }
            }
            //     -------------------------------------------------------------
            if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = 1.2;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.15;

                }
                else if (city == "Varna")
                {
                    price = 1.1;
                }
            }
            //       ---------------------------------------------
            if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = 1.45;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.30;

                }
                else if (city == "Varna")
                {
                    price = 1.35;
                }
            }
            //      -----------------------------------------------------------------
            if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = 1.60;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.50;

                }
                else if (city == "Varna")
                {
                    price = 1.55;
                }
            }
            double totalPrice = quantity * price;

            Console.WriteLine(totalPrice);
        }
    }
}
