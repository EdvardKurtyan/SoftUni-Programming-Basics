using System;

namespace _09.Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double roomForOnrPerson = 18;
            double apartment = 25;
            double president = 35;
            double price = 0;

            if (nights < 10)
            {
                if (room == "room for one person")
                {
                    price = roomForOnrPerson;
                }
                else if (room == "apartment")
                {
                    price = apartment - (0.3 * apartment);
                }
                else if (room == "president apartment")
                {
                    price = president - (0.1 * president);
                }
            }
            else if (nights >= 10 && nights < 15)
            {
                if (room == "room for one person")
                {
                    price = roomForOnrPerson;
                }
                else if (room == "apartment")
                {
                    price = apartment - (0.35 * apartment);
                }
                else if (room == "president apartment")
                {
                    price = president - (0.15 * president);
                }
            }
            else if (nights >= 15)
            {
                if (room == "room for one person")
                {
                    price = roomForOnrPerson;
                }
                else if (room == "apartment")
                {
                    price = apartment - (0.5 * apartment);
                }
                else if (room == "president apartment")
                {
                    price = president - (0.2 * president);
                }
            }

            price = price * nights;

            if (grade == "positive")
            {
                price = price + (0.25 * price);
            }
            else if (grade == "negative")
            {
                price = price - (0.1 * price);
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
