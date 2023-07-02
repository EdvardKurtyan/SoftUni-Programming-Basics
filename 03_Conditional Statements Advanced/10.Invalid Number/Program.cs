using System;

namespace _10.Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool input = num >= 100 && num <= 200;
            if (num == 0)
            {
            }
            else if (input == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
