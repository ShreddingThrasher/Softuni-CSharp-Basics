using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string input;

            while (destination != "End")
            {
                double destinationPrice = double.Parse(Console.ReadLine());
                double money = 0;

                while (money < destinationPrice)
                {
                    input = Console.ReadLine();

                    if (input == "End")
                    {
                        break;
                        destination = input;
                    }
                    money += double.Parse(input);

                    if (money >= destinationPrice)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }

                destination = Console.ReadLine();
            }

        }
    }
}
