using System;

namespace _01Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int plases = c * r;

            double ticketPrice = 0;
            switch (projection)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.5;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{ticketPrice * plases:F2} leva");
        }
    }
}
