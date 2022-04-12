using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            const double vPrice = 250;
            double pPrice = (videocards * vPrice) * 0.35;
            double rPrice = (videocards * vPrice) * 0.10;

            double totalCost = (videocards * vPrice) + (processors * pPrice) + (ram * rPrice);

            if(videocards > processors)
            {
                totalCost *= 0.85;
            }

            if(budget >= totalCost)
            {
                Console.WriteLine($"You have {budget - totalCost:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:F2} leva more!");
            }
        }
    }
}
