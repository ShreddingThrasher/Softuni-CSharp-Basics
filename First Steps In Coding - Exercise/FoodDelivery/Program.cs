using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            const double chickenPrice = 10.35;
            const double fishPrice = 12.40;
            const double veganPrice = 8.15;

            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double orderPrice = (chicken * chickenPrice) + (fish * fishPrice) + (vegan * veganPrice);
            double dessertPrice = orderPrice * 0.20;
            double total = orderPrice + dessertPrice + 2.50;

            Console.WriteLine(total);
        }
    }
}
