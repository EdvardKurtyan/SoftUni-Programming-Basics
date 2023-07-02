using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int newInput = 0;

            int sum = 0;
            while (sum < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    newInput = int.Parse(input);
                    sum += newInput;
                    break;
                }

                newInput = int.Parse(input);
                sum += newInput;

            }

            if (sum >= 10000)
            {
                sum -= 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum} steps over the goal!");
            }
            else if (sum < 10000)
            {
                sum = 10000 - sum;
                Console.WriteLine($"{sum} more steps to reach goal.");
            }
        }
    }
}
