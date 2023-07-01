using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isIntegerPalindrome = IsNumberPalindrome(input);
                Console.WriteLine(isIntegerPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsNumberPalindrome(string input)
        {
            int number = int.Parse(input);

            int counter = 0;

            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    counter++;
                }
                if (counter == input.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
