using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                for (int r = 0; r < input[i].Length; r++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
