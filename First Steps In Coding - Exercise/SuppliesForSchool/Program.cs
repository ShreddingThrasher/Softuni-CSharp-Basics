using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            const double penPrice = 5.80;
            const double markerPrice = 7.20;
            const double preparationPrice = 1.20;

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double total = ((pens * penPrice) + (markers * markerPrice) + (preparation * preparationPrice));
            double discount = total * discountPercent / 100;

            Console.WriteLine(total - discount);
        }
    }
}
