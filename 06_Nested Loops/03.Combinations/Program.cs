using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int result = 0;
            int counter = 0;
            for (int i = 0; i <= num; i++)
            {
                for (int y = 0; y <= num; y++)
                {
                    for (int g = 0; g <= num; g++)
                    {
                        result = i + y + g;
                        if (result == num)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
