using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double total = 0;

            switch (type)
            {
                case "Premiere":
                    total = rows * colums * 12.00;
                    break;
                case "Normal":
                    total = rows * colums * 7.50;
                    break;
                case "Discount":
                    total = rows * colums * 5.00;
                    break;
            }
            Console.WriteLine($"{total:F2} leva");


        }
    }
}
