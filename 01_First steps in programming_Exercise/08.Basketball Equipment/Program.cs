using System;

namespace _08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yearTax = int.Parse(Console.ReadLine());

            //                   Prices
            //Shoes - 40% less from yet tax
            double shoesPrice = yearTax - (yearTax * 0.4);
            //Outfit - 20% cheaper from shoes
            double outfitPrice = shoesPrice - (shoesPrice * 0.2);
            //Ball - 1/4 from outfi 
            double ballPrice = outfitPrice / 4;
            //Accessories - 1/5 from ball
            double accessoriesPrice = ballPrice / 5;

            //                   Wholl price
            double wholePrice = yearTax + shoesPrice + outfitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(wholePrice);

        }
    }
}
