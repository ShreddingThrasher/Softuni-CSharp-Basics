using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double sneakersPrice = taxPerYear * 0.60;
            double equipmentPrice = sneakersPrice * 0.80;
            double ballPrice = equipmentPrice / 4;
            double accessoriesPrice = ballPrice / 5;

            double total = sneakersPrice + equipmentPrice + ballPrice + accessoriesPrice + taxPerYear;

            Console.WriteLine(total);
        }
    }
}
