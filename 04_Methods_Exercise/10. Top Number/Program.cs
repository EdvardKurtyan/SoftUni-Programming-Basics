using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintingTheTopNumber(input);
        }

        private static void PrintingTheTopNumber(int input)
        {
            for (int i = 1; i < input; i++)
            {
                int sum = 0;

                int curentNumber = i;
                int copyOfCurentNumber = curentNumber;

                int oddDigitsCounter = 0;
                while (curentNumber != 0)
                {
                    curentNumber %= 10;
                    copyOfCurentNumber /= 10;

                    if (curentNumber % 2 != 0)
                    {
                        oddDigitsCounter++;
                    }
                    sum += curentNumber;
                    curentNumber = copyOfCurentNumber;
                }

                if (sum % 8 == 0 && oddDigitsCounter > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
