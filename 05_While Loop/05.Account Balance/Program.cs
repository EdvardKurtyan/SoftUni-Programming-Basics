﻿using System;

namespace _05.Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
