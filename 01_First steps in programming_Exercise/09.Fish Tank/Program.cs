using System;

namespace _09.Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            //Ocupied space in %
            double percentage = double.Parse(Console.ReadLine());

            //Volume of aquarium
            double volume = length * width * height;

            //Occupied space
            double finalLiters = volume - (volume * percentage / 100.0);

            Console.WriteLine(finalLiters / 1000);
        }
    }
}
