using System;

namespace _09.Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());

            // Price whithout discont 
            double price = yard * 7.61;

            // Discount
            double discount = 0.18 * price;

            // Price with discount 
            double discountPrice = price - discount;

            Console.WriteLine($"The final price is: {discountPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
