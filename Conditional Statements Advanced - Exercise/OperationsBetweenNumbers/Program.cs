using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            char option = char.Parse(Console.ReadLine());
            string evenOdd = "odd";

            switch (option)
            {
                case '+':
                    if ((num1 + num2) % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - {evenOdd}");
                    break;
                case '-':
                    if ((num1 - num2) % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - {evenOdd}");
                    break;
                case '*':
                    if ((num1 * num2) % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - {evenOdd}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}");
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    }
                    break;
            }
        }
    }
}
