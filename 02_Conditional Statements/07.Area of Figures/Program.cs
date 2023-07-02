
using System;

namespace _07.Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0;
            double formula = 0;

            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                formula = a * a;
                Console.WriteLine($"{formula:f3}");
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                formula = a * b;
                Console.WriteLine($"{formula:f3}");
            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                formula = Math.PI * (a * a);
                Console.WriteLine($"{formula:f3}");
            }
            else if (figure == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                formula = a * b / 2;
                Console.WriteLine($"{formula:f3}");
            }
        }
    }
}
