using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double equipmentCost = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;
            equipmentCost = equipmentCost * extra;

            if (extra > 150)
            {
                equipmentCost *= 0.9;
            }

            double total = decoration + equipmentCost;
            double remaining = budget - total;
            double needed = total - budget;

            if (equipmentCost + decoration > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needed:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remaining:F2} leva left.");
            }

        }
    }
}
