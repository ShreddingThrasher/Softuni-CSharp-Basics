using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double lihva = deposit * (percent / 100);
            double final = deposit + ((lihva / 12) * months);

            Console.WriteLine(final);
        }
    }
}
