using System;

namespace _08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogPacks = int.Parse(Console.ReadLine());
            int catPacks = int.Parse(Console.ReadLine());

            //Dog and cat food prices
            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;

            double totalPrice = dogPacks * dogFoodPrice + catFoodPrice * catPacks;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
