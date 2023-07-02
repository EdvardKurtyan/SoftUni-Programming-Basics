using System;

namespace _02.Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());

            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonus = 0.2 * points;
            }
            else if (points > 1000)
            {
                bonus = 0.1 * points;
            }


            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if (points % 10 == 5)
            {
                bonus += 2;
            }
            points = points + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(points);
        }
    }
}
