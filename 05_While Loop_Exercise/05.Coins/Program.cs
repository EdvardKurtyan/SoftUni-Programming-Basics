using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            int counter = 0;
            while (input > 0)
            {
                input = Math.Round(input, 2);
                // 100; 50; 20; 10; 5; 2; 1; 0.5; 0.2; 0.1; 0.05; 0.02; 0.01;

                if (input >= 100) // 100
                {
                    input -= 100;
                    counter++;
                }
                else if (input >= 50 && input < 100) // 50
                {
                    input -= 50;
                    counter++;
                }
                else if (input >= 20 && input < 50) // 20
                {
                    input -= 20;
                    counter++;
                }
                else if (input >= 10 && input < 20) // 10
                {
                    input -= 10;
                    counter++;
                }
                else if (input >= 5 && input < 10) // 5
                {
                    input -= 5;
                    counter++;
                }
                else if (input >= 2 && input < 5) // 2
                {
                    input -= 2;
                    counter++;
                }
                else if (input >= 1 && input < 2) // 1
                {
                    input -= 1;
                    counter++;
                }
                else if (input >= 0.5 && input < 1) // 0.5
                {
                    input -= 0.5;
                    counter++;
                }
                else if (input >= 0.2 && input < 0.5) // 0.2
                {
                    input -= 0.2;
                    counter++;
                }
                else if (input >= 0.1 && input < 0.2) // 0.1
                {
                    input -= 0.1;
                    counter++;
                }
                else if (input >= 0.05 && input < 0.1) // 0.05
                {
                    input -= 0.05;
                    counter++;
                }
                else if (input >= 0.02 && input < 0.05) // 0.02
                {
                    input -= 0.02;
                    counter++;
                }
                else if (input <= 0.01) // 0.01*/
                {
                    input -= 0.01;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
