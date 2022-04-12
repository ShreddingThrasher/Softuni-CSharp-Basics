using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double nylonPrice = 1.50;
            const double paintPrice = 14.50;
            const double thinnerPrice = 5.00;

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonTotal = (nylon + 2) * nylonPrice;
            double paintTotal = (paint + (paint * 0.10)) * paintPrice;
            double thinnerTotal = thinner * thinnerPrice;
            double packsTotal = 0.40;

            double materialsTotal = nylonTotal + paintTotal + thinnerTotal + packsTotal;
            double workersTotalCost = (materialsTotal * 0.30) * hoursNeeded;
            double total = materialsTotal + workersTotalCost;

            Console.WriteLine(total);
        }
    }
}
