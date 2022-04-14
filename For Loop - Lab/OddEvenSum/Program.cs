using System;

namespace loopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int even = 0, odd = 0;


            for (int i = 0; i < numbers; i++)
            {
                if (i % 2 == 0)
                {
                    even += int.Parse(Console.ReadLine());
                }
                else
                {
                    odd += int.Parse(Console.ReadLine());
                }
            }



            if (even == odd)
            {
                Console.WriteLine($"Yes\nSum = {even}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(even - odd)}");
            }



        }
    }
}
