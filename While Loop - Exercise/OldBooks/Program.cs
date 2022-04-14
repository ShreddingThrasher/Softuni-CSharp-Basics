using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            int count = 0;
            bool isBookFound = false;
            string input;

            while (!isBookFound)
            {
                input = Console.ReadLine();

                if (input == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }
                else if (input == "No More Books")
                {
                    break;
                }

                count++;
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
