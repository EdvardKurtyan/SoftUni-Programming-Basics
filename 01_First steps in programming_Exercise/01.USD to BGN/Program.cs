using System;

namespace _01.USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            // 1 USD = 1.79549 BGN 
            double bgn = usd * 1.79549;

            Console.WriteLine(bgn);
        }
    }
}
