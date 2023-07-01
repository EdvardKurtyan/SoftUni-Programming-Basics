using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int curentNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    curentNum = numbers[i];
                    counter++;
                }
            }
        }
    }
}
