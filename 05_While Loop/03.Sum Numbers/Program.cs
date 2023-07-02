using System;

namespace _03.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = int.Parse(Console.ReadLine());
            while (sum < num)
            {
                sum += int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
    }
}
