using System;

namespace _03.Time_Plus_15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = minutes + hours * 60;
            timeInMinutes += 15;

            double h = timeInMinutes / 60;
            double m = timeInMinutes % 60;

            if (h >= 24)
            {
                h = h - 24;
            }

            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }
        }
    }
}
