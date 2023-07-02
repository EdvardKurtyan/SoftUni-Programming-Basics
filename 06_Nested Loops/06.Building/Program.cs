using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i > 0; i--)
            {
                for (int t = 0; t < rooms; t++)
                {
                    if (i >= floors)
                    {
                        Console.Write($"L{i}{t} ");
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{t} ");
                    }
                    else
                    {
                        Console.Write($"O{i}{t} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
