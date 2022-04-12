using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area;

            switch (figure)
            {
                case "square":
                    double length = double.Parse(Console.ReadLine());
                    area = length * length;
                    Console.WriteLine($"{area:F3}");
                    break;
                case "rectangle":
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b;
                    Console.WriteLine($"{area:F3}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * (radius * radius);
                    Console.WriteLine($"{area:F3}");
                    break;
                case "triangle":
                    double strana = double.Parse(Console.ReadLine());
                    double dyljina = double.Parse(Console.ReadLine());
                    area = strana * dyljina / 2;
                    Console.WriteLine($"{area:F3}");
                    break;
            }
        }
    }
}
