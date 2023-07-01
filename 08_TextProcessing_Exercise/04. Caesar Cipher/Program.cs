using System;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> encrypted = new List<char>();

            foreach (var curentChar in input)
            {
                int ch = curentChar + 3;
                encrypted.Add((char)ch);
            }
            foreach (var item in encrypted)
            {
                Console.Write(item);
            }
        }
    }
}
