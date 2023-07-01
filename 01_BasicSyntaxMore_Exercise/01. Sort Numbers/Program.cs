using System;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            List<int> number = new List<int> { firstNumber, secondNumber, thirdNumber };

            number.Sort();
            number.Reverse();
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
