﻿using System;

namespace loopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);


        }
    }
}
