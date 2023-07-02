using System;

namespace _08.Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circlrPerimeter = 2 * Math.PI * r;
            double circlrAria = Math.PI * (r * r);

            Console.WriteLine($"{circlrAria:f2}");
            Console.WriteLine($"{circlrPerimeter:f2}");
        }
    }
}
