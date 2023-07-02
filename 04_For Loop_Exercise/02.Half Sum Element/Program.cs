using System;

namespace _02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rolls = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;
            int num = 0;
            for (int i = 0; i < rolls; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            sum -= maxNum;
            int diff = 0;
            if (maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else if (maxNum > sum)
            {
                diff = maxNum - sum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
            else if (maxNum < sum)
            {
                diff = sum - maxNum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
