using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int curentIndex = 0; curentIndex < firstLine.Length; curentIndex++)
            {
                if (firstLine[curentIndex] == secondLine[curentIndex])
                {
                    sum += firstLine[curentIndex];
                }
                else
                {   
                    Console.WriteLine($"Arrays are not identical. Found difference at {curentIndex} index");  
                    return;  
                }   
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

