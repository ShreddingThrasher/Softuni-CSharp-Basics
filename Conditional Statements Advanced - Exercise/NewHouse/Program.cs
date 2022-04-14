using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalCost = 0;

            switch (flower)
            {
                case "Roses":
                    totalCost = qty * 5;
                    if (qty > 80)
                    {
                        totalCost *= 0.90;
                    }
                    break;
                case "Dahlias":
                    totalCost = qty * 3.80;
                    if (qty > 90)
                    {
                        totalCost *= 0.85;
                    }
                    break;
                case "Tulips":
                    totalCost = qty * 2.80;
                    if (qty > 80)
                    {
                        totalCost *= 0.85;
                    }
                    break;
                case "Narcissus":
                    totalCost = qty * 3;
                    if (qty < 120)
                    {
                        totalCost *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    totalCost = qty * 2.50;
                    if (qty < 80)
                    {
                        totalCost *= 1.20;
                    }
                    break;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"Hey, you have a great garden with {qty} {flower} and {budget - totalCost:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - totalCost):F2} leva more.");
            }
        }
    }
}
