﻿using System;

namespace _06.Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // a   e   i   o   u
            // 1   2   3   4   5

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (letter == 'a')
                {
                    sum += 1;
                }
                else if (letter == 'e')
                {
                    sum += 2;
                }
                else if (letter == 'i')
                {
                    sum += 3;
                }
                else if (letter == 'o')
                {
                    sum += 4;
                }
                else if (letter == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
