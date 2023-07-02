using System;

namespace _02.Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            string taskName;
            double grade;
            double sumOfGrades = 0;
            int counter = 0;
            int counterPoorGrades = 0;
            string lastTask = "";
            while (true)
            {
                taskName = Console.ReadLine();
                if (taskName != "Enough")
                {
                    lastTask = taskName;
                }
                else
                {
                    Console.WriteLine($"Average score: {sumOfGrades / counter:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                grade = double.Parse(Console.ReadLine());
                sumOfGrades = sumOfGrades + grade;
                if (grade <= 4)
                {
                    counterPoorGrades++;
                }
                if (counterPoorGrades == poorGrades)
                {
                    Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                    break;
                }
                counter++;
            }
        }
    }
}
