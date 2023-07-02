using System;

namespace _04.Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int allToys = puzzles + dolls + bears + minions + trucks;
            double profit = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
            double storeRent = 0;

            if (allToys >= 50)
            {
                profit = profit - (0.25 * profit);
            }
            storeRent = profit * 0.1;

            double wholeProfit = profit - storeRent;

            if (wholeProfit < tripPrice)
            {
                double moneyNeeded = tripPrice - wholeProfit;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
            else
            {
                double moneyLeft = wholeProfit - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
        }
    }
}
