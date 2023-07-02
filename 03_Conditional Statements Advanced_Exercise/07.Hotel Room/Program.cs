using System;

namespace _07.Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;
            // May and October || June and September || July and August
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartamentPrice = 65;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice = studioPrice - (0.05 * studioPrice);
                    }
                    else if (nights > 14)
                    {
                        studioPrice = studioPrice - (0.3 * studioPrice);
                        apartamentPrice = apartamentPrice - (0.1 * apartamentPrice);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2;
                    apartamentPrice = 68.7;
                    if (nights > 14)
                    {
                        studioPrice = studioPrice - (0.2 * studioPrice);
                        apartamentPrice = apartamentPrice - (0.1 * apartamentPrice);
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartamentPrice = 77;
                    if (nights > 14)
                    {
                        apartamentPrice = apartamentPrice - (0.1 * apartamentPrice);
                    }
                    break;
                default:
                    break;
            }
            double wholePriceStudio = studioPrice * nights;
            double wholePriceApartament = apartamentPrice * nights;

            Console.WriteLine($"Apartment: {wholePriceApartament:F2} lv.");
            Console.WriteLine($"Studio: {wholePriceStudio:F2} lv.");
        }
    }
}
