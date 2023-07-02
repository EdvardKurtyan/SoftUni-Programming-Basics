using System;

namespace _04.Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            while (n >= num)
            {
                if (n <= num)
                {
                    Console.WriteLine(num);
                    break;
                }
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
