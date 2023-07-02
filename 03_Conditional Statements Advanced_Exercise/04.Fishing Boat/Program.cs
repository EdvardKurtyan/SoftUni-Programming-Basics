using System;

namespace _04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            bool seasons = season == "Spring" || season == "Summer" || season == "Autumn" || season == "Winter";
            if (people > 0 && seasons)
            {
                // Boat prices
                double price = 0;
                switch (season)
                {
                    case "Spring":
                        price = 3000;
                        break;
                    case "Summer":
                    case "Autumn":
                        price = 4200;
                        break;
                    case "Winter":
                        price = 2600;
                        break;
                    default:
                        break;
                }

                // Disscounts for number or people 
                if (people > 0 && people <= 6)
                {
                    price = price - (price * 0.1);
                }
                else if (people > 6 && people <= 11)
                {
                    price = price - (price * 0.15);
                }
                else if (people >= 12)
                {
                    price = price - (price * 0.25);
                }
                // Disscount if people are even (people % 2 == 0)
                // "Spring", "Summer",  "Winter"
                double excessMoney = 0;
                bool dickountSeasons = season == "Spring" || season == "Summer" || season == "Winter";
                if (price <= budget)
                {
                    if (people % 2 == 0 && dickountSeasons)
                    {
                        price = price - (price * 0.5);
                        excessMoney = budget - price;
                        Console.WriteLine($"Yes! You have {excessMoney:F2} leva left.");
                    }
                    excessMoney = budget - price;
                    Console.WriteLine($"Yes! You have {excessMoney:F2} leva left.");
                }
                else if (price > budget)
                {
                    double moneyNeeded = price - budget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
            }
        }
    }
}
