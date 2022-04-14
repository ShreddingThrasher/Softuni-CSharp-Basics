using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                if (num < 100 || num > 200)
                {
                    Console.WriteLine("invalid");
                    break;
                }
                break;
            }
        }
    }
}
