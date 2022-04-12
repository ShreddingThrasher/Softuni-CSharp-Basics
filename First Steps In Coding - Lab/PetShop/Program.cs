using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dogFoodPrice = 2.50;
            const int catFoodPrice = 4;

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double total = (dogFood * dogFoodPrice) + (catFood * catFoodPrice);

            Console.WriteLine($"{total} lv.");
        }
    }
}
