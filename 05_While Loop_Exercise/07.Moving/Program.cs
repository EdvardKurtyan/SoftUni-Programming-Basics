using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int cubMeters = length * width * height;
            int wholeCubMeters = length * width * height;

            string input = "";
            int boxes = 0;
            int sumOfBoxes = 0;
            while (cubMeters > 0)
            {
                input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                boxes = int.Parse(input);
                sumOfBoxes += boxes;
                cubMeters -= boxes;
            }
            if (sumOfBoxes >= wholeCubMeters)
            {
                sumOfBoxes -= wholeCubMeters;
                Console.WriteLine($"No more free space! You need {sumOfBoxes} Cubic meters more.");
            }
            else
            {
                wholeCubMeters -= sumOfBoxes;
                Console.WriteLine($"{wholeCubMeters} Cubic meters left.");
            }
        }
    }
}
