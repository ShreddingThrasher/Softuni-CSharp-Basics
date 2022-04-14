using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            string action = "";
            double amount = 0;
            int days = 0;
            int spendingDays = 0;

            while (true)
            {
                action = Console.ReadLine();
                amount = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    days++;
                    spendingDays++;
                    money -= amount;

                    if (money < 0)
                    {
                        money = 0;
                    }
                }
                else if (action == "save")
                {
                    money += amount;
                    days++;
                    spendingDays = 0;
                }

                if (spendingDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                else if (money >= vacationPrice)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }

        }
    }
}
