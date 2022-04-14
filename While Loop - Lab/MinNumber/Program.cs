using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double min = double.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                double num = double.Parse(input);
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
