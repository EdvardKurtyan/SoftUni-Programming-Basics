using System;

namespace _12.Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());

            //           Град    0 ≤ s ≤ 500       500 < s ≤ 1 000         1 000 < s ≤ 10 000            s > 10 000
            //           Sofia       5 %                7 %                        8 %                     12 %
            //           Varna     4.5 %              7.5 %                       10 %                     13 %
            //           Plovdiv   5.5 %                8 %                       12 %                   14.5 %

            double commission = 0;
            switch (city)
            {
                case "Sofia":
                    if (sale >= 0 && sale <= 500)
                    {
                        commission = 5;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 500 && sale <= 1000)
                    {
                        commission = 7;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 1000 && sale <= 10000)
                    {
                        commission = 8;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 10000)
                    {
                        commission = 12;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sale >= 0 && sale <= 500)
                    {
                        commission = 4.5;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 500 && sale <= 1000)
                    {
                        commission = 7.5;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 1000 && sale <= 10000)
                    {
                        commission = 10;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 10000)
                    {
                        commission = 13;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sale >= 0 && sale <= 500)
                    {
                        commission = 5.5;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 500 && sale <= 1000)
                    {
                        commission = 8;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 1000 && sale <= 10000)
                    {
                        commission = 12;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else if (sale > 10000)
                    {
                        commission = 14.5;
                        Console.WriteLine($"{sale * (commission / 100):F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
