using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());

            //Price for nylon - 1.50 + extra 2
            nylon = nylon + 2;
            double nylonPrice = nylon * 1.5;
            //Price for paint - 14.50 + extra 10%
            double paintPrice = paint * 14.5;
            double priceAfterPercent = paintPrice * 0.1;
            paintPrice = paintPrice + priceAfterPercent;
            //Price for thinner 5.00 
            double thinnerPrice = thinner * 5;

            //Price for all materials + 0.4 for plastic bags
            double priceForAllMaterials = nylonPrice + paintPrice + thinnerPrice + 0.4;

            //Price for 1 worked hour
            double priceForHour = priceForAllMaterials * 0.3;
            //Price for worked hours 
            double priceForWorkedHours = priceForHour * hoursOfWork;

            //Final price
            double finalPrice = priceForAllMaterials + priceForWorkedHours;

            Console.WriteLine(finalPrice);
        }
    }
}
