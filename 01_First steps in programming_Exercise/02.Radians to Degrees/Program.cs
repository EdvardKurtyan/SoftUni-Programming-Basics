﻿using System;

namespace _02.Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double radius = radians * 180 / Math.PI;

            Console.WriteLine(radius);
        }
    }
}
