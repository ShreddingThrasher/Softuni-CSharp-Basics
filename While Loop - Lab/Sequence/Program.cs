using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = 1;

            while (num1 <= num)
            {
                Console.WriteLine(num1);
                num1 = num1 * 2 + 1;
            }

        }
    }
}
