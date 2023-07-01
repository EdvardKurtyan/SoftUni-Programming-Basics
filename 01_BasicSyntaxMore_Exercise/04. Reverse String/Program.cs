using System;
using System.Text;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = str.Length - 1; 0 <= i; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
