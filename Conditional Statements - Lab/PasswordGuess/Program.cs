﻿using System;

namespace Number100200
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess = Console.ReadLine();

            if (guess == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
