using System;

namespace _09.Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum1 = sum1 + num;
            }
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum2 = sum2 + num;
            }


            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else if (sum1 > sum2)
            {
                int diff = sum1 - sum2;
                Console.WriteLine($"No, diff = {diff}");
            }
            else if (sum1 < sum2)
            {
                int diff = sum2 - sum1;
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
