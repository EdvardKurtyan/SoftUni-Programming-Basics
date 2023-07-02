using System;

namespace _07.Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            // The working time for 1 project is 3h
            int workingTime = 3 * projects;

            Console.WriteLine($"The architect {architect} will need {workingTime} hours to complete {projects} project/s.");
        }
    }
}
