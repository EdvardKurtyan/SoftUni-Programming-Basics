using System;

namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i:d2}:{j:d2}");
                }
            }
        }
    }
}
