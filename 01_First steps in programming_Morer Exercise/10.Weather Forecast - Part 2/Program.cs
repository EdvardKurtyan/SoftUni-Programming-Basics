using System;

namespace _10.Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees >= 26 && degrees <= 35)  //26.00 - 35.00
            {
                Console.WriteLine("Hot");
            }
            else if (degrees > 20 && degrees < 26)   //20.1 - 25.9          
            {
                Console.WriteLine("Warm");
            }
            else if (degrees >= 15 && degrees <= 20)   //15.00 - 20.00             
            {
                Console.WriteLine("Mild");
            }
            else if (degrees >= 12 && degrees < 15)   //12.00 - 14.9      
            {
                Console.WriteLine("Cool");
            }
            else if (degrees >= 5 && degrees < 12)      //5.00 - 11.9
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
