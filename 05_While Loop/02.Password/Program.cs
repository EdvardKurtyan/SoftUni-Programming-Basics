using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            string passworAtempt = Console.ReadLine();
            while (passworAtempt != password)
            {
                passworAtempt = Console.ReadLine();

            }

            if (passworAtempt == password)
            {
                Console.WriteLine($"Welcome {userName}!");

            }
        }
    }
}
