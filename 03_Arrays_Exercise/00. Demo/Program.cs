using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int t = i + 1; t < numbers.Length; t++)
                {
                    if (numbers[i] + numbers[t] == sum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[t]}");
                    }
                }
            }
        }
    }
}
