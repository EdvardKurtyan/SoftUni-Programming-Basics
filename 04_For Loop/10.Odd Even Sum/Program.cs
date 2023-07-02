using System;

namespace _10.Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rolls = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < rolls; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else if (evenSum > oddSum)
            {
                int diff = evenSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
            else if (evenSum < oddSum)
            {
                int diff = oddSum - evenSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
