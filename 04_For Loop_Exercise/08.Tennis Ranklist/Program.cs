using System;

namespace _08.Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournaments = double.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double sumOfPoints = startingPoints;
            double wonTournaments = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string position = Console.ReadLine();

                switch (position)
                {
                    case "W":
                        sumOfPoints += 2000;
                        wonTournaments++;
                        break;
                    case "F":
                        sumOfPoints += 1200;
                        break;
                    case "SF":
                        sumOfPoints += 720;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Final points: {sumOfPoints}");

            // Avarage points per tournament
            double avaragePoints = (sumOfPoints - startingPoints) / tournaments;
            Console.WriteLine($"Average points: {Math.Ceiling(avaragePoints)}");

            // % won tournaments 
            wonTournaments = (wonTournaments / tournaments) * 100;
            Console.WriteLine($"{wonTournaments:f2}%");
        }
    }
}
