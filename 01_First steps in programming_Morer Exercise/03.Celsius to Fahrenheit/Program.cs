using System;

namespace _03.Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            // °F = °C × 1,8 + 32
            double Fahrenheits = celsius * 1.8 + 32;

            Console.WriteLine($"{Fahrenheits:f2}");
        }
    }
}
