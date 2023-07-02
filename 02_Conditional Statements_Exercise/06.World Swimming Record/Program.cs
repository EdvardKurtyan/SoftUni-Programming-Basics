using System;

namespace _06.World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secontsPerMeter = double.Parse(Console.ReadLine());

            double timesDelay = meters / 15;
            double delayInTime = Math.Floor(timesDelay) * 12.5;

            double timeSwimming = meters * secontsPerMeter;
            timeSwimming = timeSwimming + delayInTime;

            if (timeSwimming < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is" +
                    $" {timeSwimming:F2} seconds.");
            }
            else if (timeSwimming >= worldRecord)
            {
                double neededTime = timeSwimming - worldRecord;
                Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
            }
        }
    }
}
