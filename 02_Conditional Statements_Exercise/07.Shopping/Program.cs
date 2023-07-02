using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buget
            double buget = double.Parse(Console.ReadLine());
            // Pieces
            int videoCrads = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            // Video cards price = 250 per 1
            int videoCradsPrice = 250 * videoCrads;
            // Processors price = 35% from video vards => video card price * 0.35
            double processirsPrice = videoCradsPrice * 0.35;
            //RAM price = 35% from video vards => video card price * 0.1
            double ramPrice = videoCradsPrice * 0.1;

            double finalPrice = videoCradsPrice + processirsPrice * processors
                + ramPrice * ram;

            if (videoCrads > processors)
            {
                // 15% discount froom final price
                finalPrice = finalPrice - (finalPrice * 0.15);
            }

            if (finalPrice <= buget)
            {
                double monryLeft = buget - finalPrice;
                Console.WriteLine($"You have {monryLeft:F2} leva left!");
            }
            else
            {
                double neededMoney = finalPrice - buget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
            }
        }
    }
}
