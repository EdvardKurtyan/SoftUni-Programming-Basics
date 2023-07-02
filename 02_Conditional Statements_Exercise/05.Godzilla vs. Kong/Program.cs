using System;

namespace _05.Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double decorPrice = buget * 0.1;
            double extrasClorhesPrice = priceForClothes * extras;
            if (extras > 150)
            {
                extrasClorhesPrice = extrasClorhesPrice - (extrasClorhesPrice * 0.1);
            }

            double fullPrice = extrasClorhesPrice + decorPrice;

            if (fullPrice > buget)
            {
                double neededMoney = fullPrice - buget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
            else
            {
                double moneyLeft = buget - fullPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
