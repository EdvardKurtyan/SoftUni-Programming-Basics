using System;

namespace _07.House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Height of the house
            double x = double.Parse(Console.ReadLine());
            // Lenght of the side
            double y = double.Parse(Console.ReadLine());
            // Height of the cover
            double h = double.Parse(Console.ReadLine());

            //                          SIDES
            //                  1 liter green paint is for 3.4 м2
            //       Need to get rid of
            // Door
            double door = 1.2 * 2;
            double windou = 1.5 * 1.5;
            //

            // Front and back side
            double frontSide = (x * x) - door;
            // Bach side
            double backSide = x * x;
            // Frond + Back side
            double frontAndBack = frontSide + backSide;

            // Left + Ride side 
            double leftAndRightSide = (x * y) * 2 - windou * 2;

            // All sides 
            double allSides = frontAndBack + leftAndRightSide;

            // Liters paint needed
            double paintForSides = allSides / 3.4;

            //                        COVER
            //                  1 liter red paint is for 4.3 м2
            // Front cover
            double frontCover = 2 * (x * h / 2);
            // Legt cover
            double leftAndRightCover = (x * y) * 2;
            // Whole cover 
            double wholeCover = frontCover + leftAndRightCover;

            // Liters paint needed
            double paintforCover = wholeCover / 4.3;



            Console.WriteLine($"{paintForSides:f2}");
            Console.WriteLine($"{paintforCover:f2}");
        }
    }
}
