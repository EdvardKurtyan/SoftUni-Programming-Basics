using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                int sumOfDigits = 0;
                int digit = i;

                while (digit != 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
