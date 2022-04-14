using System;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            switch (city)
            {
                case "Sofia":
                    if (sales == 0 || sales < 0)
                    {
                        break;
                    }
                    else if (sales <= 500)
                    {
                        comission = 0.05;
                    }
                    else if (sales <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (sales <= 10000)
                    {
                        comission = 0.08;
                    }
                    else
                    {
                        comission = 0.12;
                    }
                    break;
                case "Varna":
                    if (sales == 0 || sales < 0)
                    {
                        break;
                    }
                    else if (sales <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (sales <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (sales <= 10000)
                    {
                        comission = 0.10;
                    }
                    else
                    {
                        comission = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (sales == 0 || sales < 0)
                    {
                        break;
                    }
                    else if (sales <= 500)
                    {
                        comission = 0.055;
                    }
                    else if (sales <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (sales <= 10000)
                    {
                        comission = 0.12;
                    }
                    else
                    {
                        comission = 0.145;
                    }
                    break;
            }
            if (comission == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{sales * comission:F2}");
            }

        }
    }
}
