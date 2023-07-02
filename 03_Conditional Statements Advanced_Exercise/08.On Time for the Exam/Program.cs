using System;

namespace _08.On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());             // 10
            int minOfExam = int.Parse(Console.ReadLine());              //  20 
            int hourOfEnter = int.Parse(Console.ReadLine());    //  10
            int minOfEnter = int.Parse(Console.ReadLine());     //  20

            int examTotalMins = hourOfExam * 60 + minOfExam;
            int arriveTotalMins = hourOfEnter * 60 + minOfEnter;

            int timeLate = 0;
            int timeEarli = 0;
            int hoursLate = 0;
            int minsLate = 0;
            int minsEarli = 0;
            int hoursEarli = 0;

            if (examTotalMins == arriveTotalMins)
            {
                Console.WriteLine("On time");
            }
            else if (examTotalMins < arriveTotalMins)
            {
                Console.WriteLine("Late");
                timeLate = arriveTotalMins - examTotalMins; //90

                if (timeLate >= 60)
                {
                    hoursLate = timeLate / 60;
                    minsLate = timeLate % 60;
                    if (minsLate < 10)
                    {
                        Console.WriteLine($"{hoursLate}:0{minsLate} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hoursLate}:{minsLate} hours after the start");
                    }
                }
                else if (timeLate < 60)
                {
                    if (timeLate < 10)
                    {
                        Console.WriteLine($"0{timeLate} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeLate} minutes after the start");
                    }
                }
            }
            else if (examTotalMins > arriveTotalMins)
            {
                timeEarli = examTotalMins - arriveTotalMins; //90

                if (timeEarli >= 60)
                {
                    Console.WriteLine("Early");
                    hoursEarli = timeEarli / 60;
                    minsEarli = timeEarli % 60;
                    if (minsEarli < 10)
                    {
                        Console.WriteLine($"early {hoursEarli}:0{minsEarli} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"early {hoursEarli}:{minsEarli} hours before the start");
                    }
                }
                else if (timeEarli < 60)
                {
                    if (timeEarli <= 30)
                    {
                        Console.WriteLine("On time");
                        if (timeEarli < 10)
                        {
                            Console.WriteLine($"{timeEarli} minutes before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{timeEarli} minutes before the start");
                        }
                    }
                    else if (timeEarli > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{timeEarli} minutes before the start");
                    }
                }

            }
        }
    }
}
