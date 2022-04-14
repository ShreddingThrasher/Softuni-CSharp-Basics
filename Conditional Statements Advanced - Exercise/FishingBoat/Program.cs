using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double priceBoat = 0;
            bool isAutumn = false;


            switch (season)
            {
                case "Spring":
                    priceBoat = 3000;
                    break;
                case "Summer":
                    priceBoat = 4200;
                    break;
                case "Autumn":
                    priceBoat = 4200;
                    isAutumn = true;
                    break;
                case "Winter":
                    priceBoat = 2600;
                    break;
            }

            if (fishermen <= 6)
            {
                priceBoat *= 0.90;
            }
            else if (fishermen <= 11)
            {
                priceBoat *= 0.85;
            }
            else
            {
                priceBoat *= 0.75;
            }

            if (!isAutumn)
            {
                if (fishermen % 2 == 0)
                {
                    priceBoat *= 0.95;
                }
            }

            if (budget >= priceBoat)
            {
                Console.WriteLine($"Yes! You have {budget - priceBoat:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - priceBoat):F2} leva.");
            }



        }
    }
}
