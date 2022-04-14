using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool magic = false;
            int combinations = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        magic = true;
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        i = end + 1;
                        break;
                    }
                }
            }

            if (!magic)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
