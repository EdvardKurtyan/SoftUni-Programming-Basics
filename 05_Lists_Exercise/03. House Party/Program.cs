﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            var guests = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] action = Console.ReadLine().Split();
                string guest = action[0];
                string command = action[1] + action[2];

                switch (command)
                {
                    case "isgoing!":
                        if (!guests.Contains(guest))
                        {
                            guests.Add(guest);
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is already in the list!");
                        }
                        break;
                    case "isnot":
                        if (guests.Contains(guest))
                        {
                            guests.Remove(guest);
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is not in the list!");
                        }
                        break;
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
