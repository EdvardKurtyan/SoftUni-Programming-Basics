using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;

            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
