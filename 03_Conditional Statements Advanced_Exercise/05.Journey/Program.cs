using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string resort = "";
            double price = 0;
            double remainingMoney = 0;
            // Проверка за възможните сезони
            if (season == "summer" || season == "winter")
            {
                // Ако има <= 100лв (България)
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    // Проверка за цена при определен сезон
                    switch (season)
                    {
                        // Ако е лято цената е 30% от BUDGET
                        case "summer":
                            resort = "Camp";
                            price = budget - (0.3 * budget);
                            break;
                        // Ако е зима цената е 70% от BUDGET
                        case "winter":
                            resort = "Hotel";
                            price = budget - (0.7 * budget);
                            break;
                        default:
                            break;
                    }

                }
                // 100лв < Ако има >= 1000лв (Балканите)
                if (budget > 100 && budget <= 1000)
                {
                    destination = "Balkans";
                    // Проверка за цена при определен сезон
                    switch (season)
                    {
                        // Ако е лято цената е 40% от BUDGET
                        case "summer":
                            resort = "Camp";
                            price = budget - (0.4 * budget);
                            break;
                        // Ако е зима цената е 80% от BUDGET
                        case "winter":
                            resort = "Hotel";
                            price = budget - (0.8 * budget);
                            break;
                        default:
                            break;
                    }

                }

                // Ако има > 1000лв (Европа)
                if (budget > 1000)
                {
                    destination = "Europe";
                    // Проверка за цена при определен сезон
                    switch (season)
                    {
                        // При всеки сезон цената е 90%
                        case "summer":
                        case "winter":
                            resort = "Hotel";
                            price = budget - (0.9 * budget);
                            break;
                        default:
                            break;
                    }

                }
                if (budget > price)
                {
                    remainingMoney = budget - price;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{resort} - {remainingMoney:F2}");
                }
            }
        }
    }
}
