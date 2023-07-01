using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            double bigerKeg = double.MinValue;
            string bigerKegModel = "";
            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > bigerKeg)
                {
                    bigerKeg = volume;
                    bigerKegModel = model;
                }
            }
            Console.WriteLine(bigerKegModel);
        }
    }
}
