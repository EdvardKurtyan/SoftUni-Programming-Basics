using System;

namespace _04.Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // За колко време ще прочете цялата книга 
            int hoursForFullBook = pages / pagesPerHour;

            //Колко време тряба да чете на ден 
            int hoursPerDay = hoursForFullBook / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
