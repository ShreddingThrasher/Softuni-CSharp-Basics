using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double total = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += double.Parse(input);
                Console.WriteLine($"Increase: {double.Parse(input):F2}");

            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
