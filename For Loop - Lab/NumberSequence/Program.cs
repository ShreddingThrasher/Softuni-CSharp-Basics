using System;

namespace loopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int max = num, min = num;

            for (int i = 0; i < numbers - 1; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");



        }
    }
}
