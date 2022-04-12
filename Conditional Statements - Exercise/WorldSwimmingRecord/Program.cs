using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsMeter = double.Parse(Console.ReadLine());
            double slow = Math.Floor((meters / 15)) * 12.5;

            double ivancho = (meters * secondsMeter) + slow;
            double fail = ivancho - recordSeconds;

            if (ivancho < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivancho:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {fail:F2} seconds slower.");
            }
        }
    }
}
