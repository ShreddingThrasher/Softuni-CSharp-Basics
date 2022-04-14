using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            const double targetScore = 1250.5;

            string judgeName;
            double currentPoints;

            for (int i = 0; i < judges; i++)
            {
                judgeName = Console.ReadLine();
                currentPoints = double.Parse(Console.ReadLine());

                academyPoints += (judgeName.Length * currentPoints) / 2;

                if(academyPoints > targetScore)
                {
                    break;
                }
            }

            if(academyPoints > targetScore)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {targetScore - academyPoints:F1} more!");
            }
        }
    }
}
