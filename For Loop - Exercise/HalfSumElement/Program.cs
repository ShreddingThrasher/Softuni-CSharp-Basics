using System;

namespace LoopExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, max = 0, num;


            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }


            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sum - max)}");
            }
        }
    }
}
