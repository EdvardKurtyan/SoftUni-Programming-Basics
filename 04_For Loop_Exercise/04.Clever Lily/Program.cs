using System;

namespace _04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int present = 0;
            int presentSum = 0;
            int toy = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    present = present + 10;
                    presentSum += present - 1;
                }
                else
                {
                    toy++;
                }

            }
            double toySum = toy * toyPrice;
            double wholrPrice = toySum + presentSum;

            double diff = 0;
            if (wholrPrice >= washingMachine)
            {
                diff = wholrPrice - washingMachine;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                diff = washingMachine - wholrPrice;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
