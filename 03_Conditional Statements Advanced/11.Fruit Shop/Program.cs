using System;

namespace _11.Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter 
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());


            double price = 0;
            switch (product)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.5;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 2.7;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.20;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.25;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 0.85;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 0.90;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.45;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.60;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.7;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 3.0;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 5.50;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 5.6;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 3.85;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 4.2;
                            Console.WriteLine($"{price * quantity:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
