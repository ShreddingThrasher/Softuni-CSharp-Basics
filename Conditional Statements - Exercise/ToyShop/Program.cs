using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double talkingDollPrice = 3;
            const double teddyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = puzzles + talkingDolls + teddyBears + minions + trucks;

            double total = (puzzles * puzzlePrice) + (talkingDolls * talkingDollPrice)
                    + (teddyBears * teddyBearPrice) + (minions * minionPrice) + (trucks * truckPrice);

            if(totalToys >= 50)
            {
                total -= total * 0.25;
            }

            total -= total * 0.10;

            if(total >= tripPrice)
            {
                Console.WriteLine($"Yes! {total - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - total:F2} lv needed.");
            }
        }
    }
}
