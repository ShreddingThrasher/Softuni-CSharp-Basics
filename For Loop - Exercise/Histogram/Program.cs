using System;

namespace LoopExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }

            }

            p1 = 100 * p1 / n;
            p2 = 100 * p2 / n;
            p3 = 100 * p3 / n;
            p4 = 100 * p4 / n;
            p5 = 100 * p5 / n;

            Console.WriteLine($"{p1:F2}%\n{p2:F2}%\n{p3:F2}%\n{p4:F2}%\n{p5:F2}%");


        }
    }
}
