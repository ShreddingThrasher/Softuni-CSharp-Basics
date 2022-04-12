using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int requiredTime = 3;

            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {requiredTime * projects} hours to complete {projects} project/s.");
        }
    }
}
