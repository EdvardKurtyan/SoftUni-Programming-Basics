using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int countDys = 0;
            while (money < neededMoney)
            {
                string input = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                countDys++;

                if (money <= 0)
                {
                    money = 0;
                }
                if (input == "save")
                {
                    money += price;

                }
                else if (input == "spend")
                {
                    spendingCounter++;
                    if (spendingCounter == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(countDys);
                        break;
                    }
                    money -= price;
                }
            }
            if (money >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {countDys} days.");
            }
        }
    }
}
