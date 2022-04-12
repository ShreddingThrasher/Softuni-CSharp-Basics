using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int greater = 0;

            if (num1 > num2)
            {
                greater = num1;
            }
            else
            {
                greater = num2;
            }

            Console.WriteLine(greater);
        }
    }
}
