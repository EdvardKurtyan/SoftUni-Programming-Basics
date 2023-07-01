using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] action = command.Split().ToArray();
                string instruction = action[0];

                if (instruction == "Add")
                {
                    wagons.Add(int.Parse(action[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(action[0]) <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(action[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
        }
    }
}
