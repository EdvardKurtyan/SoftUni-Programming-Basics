using System;

namespace _05.Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме ДЪЛИЖИНА и ШИРОЧИНА 
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            // Обръщаме в см
            l = l * 100;
            w = w * 100;

            // Редове 
            double redove = l % 120;
            redove = l - redove;
            redove = redove / 120;
            // Места на ред 
            w = w - 100;
            double mestaNaRed = w % 70;
            mestaNaRed = w - mestaNaRed;
            mestaNaRed = mestaNaRed / 70;

            // Места 
            Console.WriteLine(redove * mestaNaRed - 3);
        }
    }
}
