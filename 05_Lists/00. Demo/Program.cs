using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> summedList = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                summedList.Add(input[i] + input[input.Count - 1 - i]);
            }

            if (input.Count % 2 != 0)
            {
                summedList.Add(input[input.Co / 2]);
            }
            Console.WriteLine(string.Join(' ', summedList));
        }
    }
}
