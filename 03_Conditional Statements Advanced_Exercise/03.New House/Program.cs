using System;

namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Входящи данни 
            string flowerTipe = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            // Проверка цвете 
            switch (flowerTipe)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
                default:
                    break;
            }
            double finalPrice = price * numberOfFlowers;

            if (numberOfFlowers > 80 && flowerTipe == "Roses")
            {
                finalPrice = finalPrice - (finalPrice * 0.1);
            }
            else if (numberOfFlowers > 90 && flowerTipe == "Dahlias")
            {
                finalPrice = finalPrice - (finalPrice * 0.15);
            }
            else if (numberOfFlowers > 80 && flowerTipe == "Tulips")
            {
                finalPrice = finalPrice - (finalPrice * 0.15);
            }
            else if (numberOfFlowers < 120 && flowerTipe == "Narcissus")
            {
                finalPrice = finalPrice + (finalPrice * 0.15);
            }
            else if (numberOfFlowers < 80 && flowerTipe == "Gladiolus")
            {
                finalPrice = finalPrice + (finalPrice * 0.2);
            }

            // проверка дали са останали пари 

            if (finalPrice <= budget)
            {
                finalPrice = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerTipe}" +
                    $" and {finalPrice:F2} leva left.");
            }
            else if (budget < finalPrice)
            {
                finalPrice = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {finalPrice:F2} leva more.");
            }
        }
    }
}
