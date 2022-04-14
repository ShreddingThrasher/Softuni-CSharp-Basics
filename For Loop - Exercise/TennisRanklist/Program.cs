using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamets = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double pointsFromTournaments = 0;
            double wonTournaments = 0;

            for (int i = 0; i < tournamets; i++)
            {
                string ranking = Console.ReadLine();

                switch (ranking)
                {
                    case "W":
                        pointsFromTournaments += 2000;
                        wonTournaments++;
                        break;
                    case "F":
                        pointsFromTournaments += 1200;
                        break;
                    case "SF":
                        pointsFromTournaments += 720;
                        break;

                }
            }

            Console.WriteLine($"Final points: {points + pointsFromTournaments}");
            Console.WriteLine($"Average points: {Math.Floor(pointsFromTournaments / tournamets)}");
            Console.WriteLine($"{(wonTournaments / tournamets) * 100:F2}%");
        }
    }
}
