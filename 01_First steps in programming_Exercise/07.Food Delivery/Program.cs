using System;

namespace _07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());

            //Chicken Price 10.35 
            double chickenPrice = chicken * 10.35;
            //Fish Price 12.40 
            double fishPrice = fish * 12.4;
            //Vegetarian menu price 8.15 
            double vegetarianMenuPrice = vegetarian * 8.15;
            //Price for everiting without dessetr
            double priceWithoutDessert = chickenPrice + fishPrice + vegetarianMenuPrice;
            //Dessert price
            double dessetrPrice = priceWithoutDessert * 20 / 100.0;

            //Whole price + 2.5 for delivery
            double wholePrice = priceWithoutDessert + dessetrPrice + 2.5;

            Console.WriteLine(wholePrice);
        }
    }
}
