using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalWalk = 0;
            string input;
            int steps;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalWalk += steps;

                    if (totalWalk >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{totalWalk - goal} steps over the goal!");
                        break;
                    }
                    else if (totalWalk < goal)
                    {
                        Console.WriteLine($"{goal - totalWalk} more steps to reach goal.");
                        break;
                    }

                }

                steps = int.Parse(input);
                totalWalk += steps;

                if (totalWalk >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalWalk - goal} steps over the goal!");
                    break;
                }
            }
        }
    }
}
