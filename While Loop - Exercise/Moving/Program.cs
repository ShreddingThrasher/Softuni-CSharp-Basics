using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input;
            int boxes = 0;
            int totalSpace = width * length * height;

            while((input = Console.ReadLine()) != "Done")
            {
                boxes += int.Parse(input);

                if(boxes > totalSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxes - totalSpace} Cubic meters more.");
                    return;
                }
            }

            Console.WriteLine($"{totalSpace - boxes} Cubic meters left.");
        }
    }
}
