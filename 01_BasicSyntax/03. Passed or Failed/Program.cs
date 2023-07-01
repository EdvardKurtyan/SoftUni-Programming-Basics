using System;

namespace PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!"!);
            }
        }
    }
}
