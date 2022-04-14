using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cake = width * length;
            int pieces;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }

                pieces = int.Parse(input);

                cake -= pieces;

                if (cake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    break;
                }
            }
        }
    }
}
