using System;

namespace _03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Депозитна сума
            double deposit = double.Parse(Console.ReadLine());
            // Срок на депозита 
            int term = int.Parse(Console.ReadLine());
            // Годишен лихвен процент
            double interestRate = double.Parse(Console.ReadLine());

            //Изчисление на натрупаната лихва 
            double interest = deposit * interestRate / 100.0;

            // Изчисление на лихвата за 1 месец
            double interestPerMount = interest / 12;

            // Обща сума 
            double price = deposit + term * interestPerMount;

            Console.WriteLine(price);
        }
    }
}
