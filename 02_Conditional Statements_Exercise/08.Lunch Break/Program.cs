using System;

namespace _08.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            // Breack duration (Продължителност на почивката)
            int breackDuration = int.Parse(Console.ReadLine());

            // Time to eat
            double timeForLunch = breackDuration * 1 / 8.0;

            // Time to rest(отдих)
            double timeForRest = breackDuration * 1 / 4.0;

            // Time to rest + Time to eat + Episode duration
            //double wholleTime = timeForRest + timeForLunch + episodeDuration; ;

            // Checking if the time left is more than the episode
            double timeLeftForEpisode = breackDuration - timeForLunch - timeForRest;

            if (timeLeftForEpisode >= episodeDuration)
            {
                double timeLeft = timeLeftForEpisode - episodeDuration; ;
                Console.WriteLine($"You have enough time to watch {movieName} and left " +
                    $"with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double timeNeeded = episodeDuration - timeLeftForEpisode;
                Console.WriteLine($"You don't have enough time to watch {movieName}, " +
                    $"you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}
