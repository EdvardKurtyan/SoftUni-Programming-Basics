using System;

namespace _11MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int input = int.Parse(Console.ReadLine());
            int stratingNum = int.Parse(Console.ReadLine());

            if (stratingNum > 10)
            {
                Console.WriteLine($"{input} X {stratingNum} = {input * stratingNum}");
                return;
            }

            for (int i = stratingNum; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}
