using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double inchesToCentimeters = inches * 2.54;

            Console.WriteLine(inchesToCentimeters);
        }
    }
}
