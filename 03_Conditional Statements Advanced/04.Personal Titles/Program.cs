﻿using System;

namespace _04.Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());


            switch (gender)
            {
                case 'm':
                    if (age < 16)
                    {
                        Console.WriteLine("Master");

                    }
                    else if (age >= 16)
                    {
                        Console.WriteLine("Mr.");

                    }
                    break;
                case 'f':
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    break;
            }
        }
    }
}
