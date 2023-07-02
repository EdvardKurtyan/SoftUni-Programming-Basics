using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double neededMoney = 0;

            double savings = 0;
            double money = 0;

            while (true)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                neededMoney = double.Parse(Console.ReadLine());
                savings = 0;

                while (savings < neededMoney)
                {
                    money = double.Parse(Console.ReadLine());
                    savings += money;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
