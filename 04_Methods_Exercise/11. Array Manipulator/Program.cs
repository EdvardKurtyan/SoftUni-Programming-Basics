using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] action = command.Split().ToArray();

                switch (action[0])
                {
                    case "exchange":
                       // ExchagingTheInput(input, action[1]);
                        break;
                    case "max":
                        if (action[1] == "even")
                            Console.WriteLine(MaxEvenNumber(input));
                        if (action[1] == "odd")
                            Console.WriteLine(MaxOddNumber(input));
                        break;
                    case "min":
                        if (action[1] == "even")
                            Console.WriteLine(MinEvenNumber(input));
                        if (action[1] == "odd")
                            Console.WriteLine(MinOddNumber(input));
                        break;
                    case "first":
                        int curentAction = int.Parse(action[1]);
                        Console.WriteLine(ListOfFirstEvenElements(input, curentAction));
                        break;
                    case "last":
                        int curentAction = int.Parse(action[1]);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static List<int> ListOfFirstEvenElements(List<int> input, int counter)
        {
            List<int> firstEvenNumbers = new List<int>();
            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    firstEvenNumbers.Add(number);
                    counter--;
                }
                if (counter == 0) break;
            }
            return firstEvenNumbers;

            private static List<int> ListOfLastEvenElements(List<int> input, int counter)
            {
                List<int> firstOddNumbers = new List<int>();
                foreach (var number in input)
                {
                    if (number % 2 != 0)
                    {
                        firstOddNumbers.Add(number);
                        counter++;
                    }
                }
            }
        }

        private static void ExchagingTheInput(List<int> input, int action)
        {
            // How to make the exchange action
        }

        private static int MinOddNumber(List<int> input)
        {
            int minOdd = int.MaxValue;
            int minOddIndex = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (minOdd > input[i] && input[i] % 2 == 0)
                {
                    minOdd = input[i];
                    minOddIndex = i;
                }
            }
            return minOddIndex;
        }
        private static int MinEvenNumber(List<int> input)
        {
            int minEven = int.MaxValue;
            int minEvenIndex = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (minEven > input[i] && input[i] % 2 != 0)
                {
                    minEven = input[i];
                    minEvenIndex = i;
                }
            }
            return minEvenIndex;
        }

        private static int MaxOddNumber(List<int> input)
        {
            int maxOdd = int.MinValue;
            int maxOddIndex = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (maxOdd < input[i] && input[i] % 2 == 0)
                {
                    maxOdd = input[i];
                    maxOddIndex = i;
                }
            }
            return maxOddIndex;
        }

        private static int MaxEvenNumber(List<int> input)
        {
            int maxEven = int.MinValue;
            int maxEvenIndex = int.MinValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (maxEven < input[i] && input[i] % 2 != 0)
                {
                    maxEven = input[i];
                    maxEvenIndex = i;
                }
            }
            return maxEvenIndex;
        }
    }
}
