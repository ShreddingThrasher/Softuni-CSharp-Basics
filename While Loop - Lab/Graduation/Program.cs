using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double averageGrade = 0;

            int years = 0;
            int fails = 0;
            double grade;

            while (years != 12)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;

                if (grade < 4.00)
                {
                    fails++;
                }

                if (fails > 1)
                {
                    Console.WriteLine($"{student} has been excluded at {years} grade");
                    break;
                }

                years++;

                if (years == 12)
                {
                    Console.WriteLine($"{student} graduated. Average grade: {averageGrade / years:F2}");
                    break;
                }
            }

        }
    }
}
