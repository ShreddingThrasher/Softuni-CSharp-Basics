using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            double money = 0;

            int moneyPerEvenBirthday = 10;

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 != 0)
                {
                    toys++;
                }
                else
                {
                    money += moneyPerEvenBirthday;
                    moneyPerEvenBirthday += 10;
                    money--;
                }
            }

            money += toys * toyPrice;

            if(money >= neededMoney)
            {
                Console.WriteLine($"Yes! {money - neededMoney:F2}");
            }
            else
            {
                Console.WriteLine($"No! {neededMoney - money:F2}");
            }
        }
    }
}
