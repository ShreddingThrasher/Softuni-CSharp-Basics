using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double max = double.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                double num = double.Parse(input);
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
