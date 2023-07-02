using System;

namespace _01.Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            bool ending = false;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{count++} ");
                    if (count > n)
                    {
                        ending = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (ending) break;
            }
        }
    }
}
