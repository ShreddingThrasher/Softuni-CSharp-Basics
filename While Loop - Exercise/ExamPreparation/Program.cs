using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            string exercise = "";
            int grade;

            double totalGrades = 0;
            int failedTimes = 0;
            int solved = 0;
            bool enough = false;
            string lastExercise = "";

            while (!enough)
            {
                lastExercise = exercise;
                exercise = Console.ReadLine();

                if (exercise == "Enough")
                {
                    double Average = totalGrades / solved;
                    Console.WriteLine($"Average score: {Average:F2}");
                    Console.WriteLine($"Number of problems: {solved}");
                    Console.WriteLine($"Last problem: {lastExercise}");
                    enough = true;
                    break;
                }

                grade = int.Parse(Console.ReadLine());
                totalGrades += grade;
                solved++;

                if (grade <= 4)
                {
                    failedTimes++;
                }

                if (failedTimes == failedThreshold)
                {
                    Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                    break;
                }
            }
        }
    }
}
