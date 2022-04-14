using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation = "";
            double totalScores = 0;
            int projects = 0;

            while (true)
            {
                presentation = Console.ReadLine();
                double score = 0;

                if (presentation == "Finish")
                {
                    break;
                }

                for (int i = 0; i < judges; i++)
                {
                    score += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"{presentation} - {score / judges:F2}.");
                totalScores += score / judges;
                projects++;
            }

            Console.WriteLine($"Student's final assessment is {totalScores / projects:F2}.");
        }
    }
}
