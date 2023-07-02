using System;

namespace _05.Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            // Pens price 5.80
            double penPrice = pens * 5.8;
            // Markers price 7.20 
            double markersPrice = markers * 7.2;
            // Preparation price 1.20 
            double preparationPrice = preparation * 1.2;

            // Price for all
            double price = penPrice + markersPrice + preparationPrice;

            //Price after discount
            double priceAfterDiscount = price - (percentDiscount / 100.0 * price);

            Console.WriteLine(priceAfterDiscount);
        }
    }
}
