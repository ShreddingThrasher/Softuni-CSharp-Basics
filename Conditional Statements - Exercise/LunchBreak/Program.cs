using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeriesName = Console.ReadLine();
            int seriesLength = int.Parse(Console.ReadLine());
            double restTime = double.Parse(Console.ReadLine());

            double lunchTime = restTime / 8;
            double napTime = restTime / 4;

            double freeTime = restTime - lunchTime - napTime;

            Console.WriteLine(lunchTime);
            Console.WriteLine(napTime);
            Console.WriteLine(freeTime);

            if(freeTime >= seriesLength)
            {
                Console.WriteLine($"You have enough time to watch {tvSeriesName} and left with {Math.Ceiling(freeTime - seriesLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvSeriesName}, you need {Math.Ceiling(seriesLength - freeTime)} more minutes.");
            }
        }
    }
}
