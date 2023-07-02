using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            double mark = 0;
            double sumOfMarks = 0;
            int count = 0;
            while (grade <= 12)
            {
                mark = double.Parse(Console.ReadLine());
                if (mark < 4)
                {
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at " +
                            $"{grade} grade");
                        break;
                    }
                }
                else
                {
                    grade++;
                    sumOfMarks += mark;
                }
            }
            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade:" +
                    $" {sumOfMarks / (grade - 1):f2}");
            }
        }
    }
}
