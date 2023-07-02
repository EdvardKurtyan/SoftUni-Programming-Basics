using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double sumP1 = 0;
            double sumP2 = 0;
            double sumP3 = 0;
            double sumP4 = 0;
            double sumP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    sumP1 = sumP1 + (num - (num - 1));
                }
                else if (num >= 200 && num < 400)
                {
                    sumP2 = sumP2 + (num - (num - 1));
                }
                else if (num >= 400 && num < 600)
                {
                    sumP3 = sumP3 + (num - (num - 1));
                }
                else if (num >= 600 && num < 800)
                {
                    sumP4 = sumP4 + (num - (num - 1));
                }
                else if (num >= 800)
                {
                    sumP5 = sumP5 + (num - (num - 1));
                }
            }
            sumP1 = sumP1 / n * 100;
            sumP2 = sumP2 / n * 100;
            sumP3 = sumP3 / n * 100;
            sumP4 = sumP4 / n * 100;
            sumP5 = sumP5 / n * 100;

            Console.WriteLine($"{sumP1:f2}%");
            Console.WriteLine($"{sumP2:f2}%");
            Console.WriteLine($"{sumP3:f2}%");
            Console.WriteLine($"{sumP4:f2}%");
            Console.WriteLine($"{sumP5:f2}%");
        }
    }
}
