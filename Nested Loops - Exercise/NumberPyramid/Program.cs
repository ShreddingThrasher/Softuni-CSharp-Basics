using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= x; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > x)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}
