using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string input = "";
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                num = int.Parse(input);
                int count = 0;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
