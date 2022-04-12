using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePerSquareMeter = 7.61;

            double area = double.Parse(Console.ReadLine());
            double total = area * pricePerSquareMeter;

            Console.WriteLine($"The final price is: {total * 0.82} lv.");
            Console.WriteLine($"The discount is: {total * 0.18} lv.");
        }
    }
}
