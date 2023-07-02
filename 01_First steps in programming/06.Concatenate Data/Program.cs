using System;

namespace _06.Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string sirname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();

            Console.WriteLine($"You are {name} {sirname}, a {age}-years old person from {city}.");
        }
    }
}
