using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // // First attempt 
            // const int CAPACITY = 255;
            // int lines = int.Parse(Console.ReadLine());
            //
            // int sum = 0;
            // for (int i = 0; i < lines; i++)
            // {
            //     int curentPours = int.Parse(Console.ReadLine());
            //     sum += curentPours;
            //     while (sum > CAPACITY)
            //     {
            //         Console.WriteLine("Insufficient capacity!");
            //         sum -= curentPours;
            //         i++;
            //         if (i < lines == false)
            //         {
            //             break;
            //         }
            //         curentPours = int.Parse(Console.ReadLine());
            //         sum += curentPours;
            //     }
            // }
            // Console.WriteLine(sum);


            // Second attempt
            // Constant for the capacity 
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int currQuantity = int.Parse(Console.ReadLine());
                if (totalQuantity - currQuantity >= 0)
                {
                    totalQuantity -= currQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalFieldQuntitiy = CAPACITY - totalQuantity;
            Console.WriteLine(totalFieldQuntitiy);
        }
    }
}
