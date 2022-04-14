using System;

namespace loopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int left = 0, right = 0;


            for (int i = 0; i < numbers; i++)
            {
                left += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers; i++)
            {
                right += int.Parse(Console.ReadLine());
            }

            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");

            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }



        }
    }
}
