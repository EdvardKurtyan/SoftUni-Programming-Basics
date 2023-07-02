using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // цена на скумрията
            double mackerelPrice = double.Parse(Console.ReadLine());
            // цена на цацата на кило
            double sprats = double.Parse(Console.ReadLine());
            // килограма паламуд
            double bonito = double.Parse(Console.ReadLine());
            // килограма сафрид. 
            double horseMackerel = double.Parse(Console.ReadLine());
            // илограма миди
            int mussels = int.Parse(Console.ReadLine());

            // Цена на паламуд
            double bonitoPrice = mackerelPrice + mackerelPrice * 0.6;  //11.04
            bonitoPrice = bonitoPrice * bonito;   // 16.56

            // Цена на сафрид
            double horseMackerelPrice = sprats + sprats * 0.8;
            horseMackerelPrice = horseMackerel * horseMackerelPrice;

            // Цена на мидите
            double musselsPrice = mussels * 7.5;

            // Цялата сума 
            double wholePrice = bonitoPrice + horseMackerelPrice + musselsPrice;


            Console.WriteLine($"{wholePrice:f2}");
        }
    }
}
