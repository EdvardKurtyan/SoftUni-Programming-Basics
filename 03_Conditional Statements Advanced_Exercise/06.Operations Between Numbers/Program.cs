using System;

namespace _06.Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());

            string evenOrOdd = "";
            double result = 0;
            if (n1 > 0 && n2 > 0)
            {
                switch (simbol)
                {
                    case '+':
                        result = n1 + n2;
                        if (result % 2 == 0)
                        {
                            evenOrOdd = "even";
                        }
                        else if (result % 2 != 0)
                        {
                            evenOrOdd = "odd";
                        }
                        Console.WriteLine($"{n1} + {n2} = {result} - {evenOrOdd}");
                        break;
                    case '-':
                        result = n1 - n2;
                        if (result % 2 == 0)
                        {
                            evenOrOdd = "even";
                        }
                        if (result % 2 != 0)
                        {
                            evenOrOdd = "odd";
                        }
                        Console.WriteLine($"{n1} - {n2} = {result} - {evenOrOdd}");
                        break;
                    case '*':
                        result = n1 * n2;
                        if (result % 2 == 0)
                        {
                            evenOrOdd = "even";
                        }
                        if (result % 2 != 0)
                        {
                            evenOrOdd = "odd";
                        }
                        Console.WriteLine($"{n1} * {n2} = {result} - {evenOrOdd}");
                        break;
                    case '/':
                        result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:F2}");
                        break;
                    case '%':
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                        break;
                    default:
                        break;
                }
            }
            else if (n1 == 0)
            {
                Console.WriteLine($"Cannot divide {n2} by zero");
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
