using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var registeredCars = new Dictionary<string, string>();

            string action = null;
            string ownerName = null;
            string ownerPlate = null;
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                action = input[0];
                ownerName = input[1];
                if (input.Length > 2)
                {
                    ownerPlate = input[2];
                }

                //string[] input = Console.ReadLine().Split();

                switch (action)
                {
                    case "register":
                        if (registeredCars.ContainsKey(ownerName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {ownerPlate}");
                        }
                        else
                        {
                            Console.WriteLine($"{ownerName} registered {ownerPlate} successfully");
                            registeredCars.Add(ownerName, ownerPlate);
                        }
                        break;
                    case "unregister":
                        if (!registeredCars.ContainsKey(ownerName))
                        {
                            Console.WriteLine($"ERROR: user {ownerName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{ownerName} unregistered successfully");
                            registeredCars.Remove(ownerName);
                        }
                        break;
                }
            }
            foreach (var car in registeredCars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
