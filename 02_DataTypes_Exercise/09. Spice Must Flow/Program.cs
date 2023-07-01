using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spices = int.Parse(Console.ReadLine());
            int copySpices = int.Parse(Console.ReadLine());
            int workersConsume = 26;


            while (spices >= 100)
            {
                spices -= 10;
                copySpices -= workersConsume;
            }
        }
    }
}
