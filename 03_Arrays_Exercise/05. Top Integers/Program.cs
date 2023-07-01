using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int topNum = int.MinValue;
            int[] topNumArr = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (topNum < arr[i])
                {
                    topNum = arr[i];
                    topNumArr[i] = topNum;
                }
            }
            foreach (var curentNumber in topNumArr)
            {
                if (curentNumber != 0)
                {
                    Console.Write(curentNumber + " ");
                }
            }

        }
    }
}
