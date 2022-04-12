using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bonus;

            if (n <= 100)
            {
                bonus = 5;
            }
            else if (n < 1000)
            {
                bonus = n * 0.20;
            }
            else
            {
                bonus = n * 0.1;
            }

            if (n % 2 == 0)
            {
                bonus += 1;
            }
            if (n % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + n);



        }
    }
}
