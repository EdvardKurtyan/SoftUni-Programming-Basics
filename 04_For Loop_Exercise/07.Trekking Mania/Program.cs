using System;

namespace _07.Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grourNum = int.Parse(Console.ReadLine());

            double musla = 0;
            double montblanc = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            double sumOfPeople = 0;
            for (int i = 0; i < grourNum; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumOfPeople = sumOfPeople + people;

                if (people < 6)
                {
                    musla = musla + people;
                }
                else if (people >= 6 && people <= 12)
                {
                    montblanc = montblanc + people;
                }
                else if (people > 12 && people <= 25)
                {
                    kilimanjaro = kilimanjaro + people;
                }
                else if (people > 25 && people <= 40)
                {
                    k2 = k2 + people;
                }
                else if (people > 40)
                {
                    everest = everest + people;
                }
            }
            double musalaPersent = musla / sumOfPeople * 100;
            double montblacPersent = montblanc / sumOfPeople * 100;
            double kilianjaroPersent = kilimanjaro / sumOfPeople * 100;
            double k2Persent = k2 / sumOfPeople * 100;
            double everestPersent = everest / sumOfPeople * 100;

            Console.WriteLine($"{musalaPersent:f2}%");
            Console.WriteLine($"{montblacPersent:f2}%");
            Console.WriteLine($"{kilianjaroPersent:f2}%");
            Console.WriteLine($"{k2Persent:f2}%");
            Console.WriteLine($"{everestPersent:f2}%");
        }
    }
}
