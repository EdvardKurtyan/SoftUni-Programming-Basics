using System;

namespace _00._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int lines = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                int curentPours = int.Parse(Console.ReadLine());
                sum += curentPours;
                while (sum > CAPACITY)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= curentPours;
                    i++;
                    if (i < lines == false)
                    {
                        break;
                    }
                    curentPours = int.Parse(Console.ReadLine());
                    sum += curentPours;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
