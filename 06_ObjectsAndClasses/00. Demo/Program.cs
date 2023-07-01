using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                string[] input = command.Split().ToArray();
                string firstName = command[0];
                string lastName = command[1]

                bool existing = true;
                foreach (var currentStudent in allStudents)
                {
                    if (currentStudent.FirstName == command[0] && currentStudent.LastName == lastName)
                    {

                    }
                }
                if (ExistingStudent(allStudents, input[0], input[1]))
                {
                    Student student = new Student(input[0], input[1], int.Parse(input[2]), input[3]);
                    allStudents.Add(student);
                }
                for (int i = 0; i < allStudents.Count; i++)
                {

                }
            }
        }

        static bool ExistingStudent(List<Student> allStudents, string firstName, string lastName)
        {
            foreach (var currentStudent in allStudents)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                     
                }
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
