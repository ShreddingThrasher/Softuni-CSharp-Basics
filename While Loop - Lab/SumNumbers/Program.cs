using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum != num)
            {
                sum += int.Parse(Console.ReadLine());
                if (sum > num)
                {
                    break;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
