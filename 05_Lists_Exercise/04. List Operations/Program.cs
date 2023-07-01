using System;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                switch (action)
                {
                    case "Add":
                        input.Add(int.Parse(token[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(token[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(token[1]));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        input.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Shift":
                        if (token[1] == "left")
                        {
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
