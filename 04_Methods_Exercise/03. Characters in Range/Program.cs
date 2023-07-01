using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            PrintingTheResult(startChar, endChar);
        }

        private static void PrintingTheResult(char startChar, char endChar)
        {

            for (int i = Math.Min(startChar, endChar) + 1; i < Math.Max(startChar, endChar); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
