using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";

            switch (season)
            {
                case "summer":
                    place = "Camp";
                    if (budget <= 100)
                    {
                        budget *= 0.30;
                        destination = "Bulgaria";
                    }
                    else if (budget <= 1000)
                    {
                        budget *= 0.40;
                        destination = "Balkans";
                    }
                    else
                    {
                        budget *= 0.90;
                        destination = "Europe";
                        place = "Hotel";
                    }
                    break;
                case "winter":
                    place = "Hotel";
                    if (budget <= 100)
                    {
                        budget *= 0.70;
                        destination = "Bulgaria";
                    }
                    else if (budget <= 1000)
                    {
                        budget *= 0.80;
                        destination = "Balkans";
                    }
                    else
                    {
                        budget *= 0.90;
                        destination = "Europe";
                    }
                    break;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budget:F2}");

        }
    }
}
