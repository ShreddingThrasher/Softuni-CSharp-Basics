using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.50;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 2.70;
                            break;
                        default:
                            break;

                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.20;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.25;
                            break;
                        default:
                            break;

                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 0.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 0.90;
                            break;
                        default:
                            break;

                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.45;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.60;
                            break;
                        default:
                            break;

                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.70;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 3.00;
                            break;
                        default:
                            break;

                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 5.50;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 5.60;
                            break;
                        default:
                            break;

                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 3.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 4.20;
                            break;
                        default:
                            break;

                    }
                    break;
                default:
                    break;

            }
            if (price > 0)
            {
                Console.WriteLine($"{ qty * price:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
