using System;
using System.Collections.Generic;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            var studentsCountPerCourse = new Dictionary<string, int>();
            //List<string> allStudents = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                string[] input = command.Split(" : ");
                string courseName = input[0];
                string student = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(student);
            }
            foreach (var course in courses)
            {
                string courseName = course.Key;
                var students = course.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
