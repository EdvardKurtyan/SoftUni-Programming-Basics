using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var allResources = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!allResources.ContainsKey(resource))
                {
                    allResources.Add(resource, 0);
                }
                allResources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in allResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
