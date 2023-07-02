using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numOfJury = int.Parse(Console.ReadLine());

            double pointsSum = academyPoints;
            for (int i = 0; i < numOfJury; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                juryPoints = (juryName.Length * juryPoints / 2);

                pointsSum = pointsSum + juryPoints;

                if (pointsSum >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with" +
                        $" {pointsSum:f1}!");
                    break;
                }

                //for (int u = 0; u < jury.Length; u++)
                //{
                //
                //}
            }
            if (pointsSum < 1250.5)
            {
                double diff = 1250.5 - pointsSum;
                Console.WriteLine($"Sorry, {actorName} you need {diff:f1} more!");
            }
        }
    }
}
