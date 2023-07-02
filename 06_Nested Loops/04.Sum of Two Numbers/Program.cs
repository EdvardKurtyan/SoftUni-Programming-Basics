using System;

namespace _04.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInterval = int.Parse(Console.ReadLine());
            int secondInterval = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool isMagicNum = false;
            int counter = 0;
            int result;
            for (int i = firstInterval; i <= secondInterval; i++)
            {
                for (int t = firstInterval; t <= secondInterval; t++)
                {
                    counter++;
                    result = i + t;
                    if (i + t == magicNum)
                    {
                        isMagicNum = true;
                        Console.Write($"Combination N:{counter} ");
                        Console.WriteLine($"({i} + {t} = {magicNum})");
                        return;
                    }
                }
            }
            if (!isMagicNum)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
