using System;

namespace _01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string neededBook = Console.ReadLine();

            string serchedBook;
            int counter = 0;
            while (true)
            {
                serchedBook = Console.ReadLine();
                if (serchedBook == neededBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                if (serchedBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
            }
        }
    }
}
