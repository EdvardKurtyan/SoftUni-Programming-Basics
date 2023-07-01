using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //  OutFall 4                   $39.99

            //  CS: OG                      $15.99

            //  Zplinter Zell	            $19.99

            //  Honored 2                   $59.99

            //  RoverWatch                  $29.99

            //  RoverWatch Origins Edition  $39.99

            double balance = double.Parse(Console.ReadLine());
            double totalSpend = 0;
            string command = Console.ReadLine();

            double gamePrice = 0;
            while (command != "Game Time")
            {
                bool gameNotFound = false;
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        gameNotFound = true;
                        break;

                }
                if (gameNotFound == true)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (balance == gamePrice)
                {
                    Console.WriteLine($"Bought {command}");
                    totalSpend += gamePrice;
                    balance -= gamePrice;
                    command = Console.ReadLine();
                    continue;
                }
                balance -= gamePrice;
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else if (balance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    balance += gamePrice;
                }
                if (balance > 0)
                {
                    Console.WriteLine($"Bought {command}");
                    totalSpend += gamePrice;
                }

                command = Console.ReadLine();
            }
            if (balance > 0)
            {
                Console.Write($"Total spent: ${totalSpend:f2}.");
                Console.WriteLine($" Remaining: ${balance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
