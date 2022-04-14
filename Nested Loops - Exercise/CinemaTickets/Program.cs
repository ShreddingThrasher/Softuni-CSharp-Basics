using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie;

            double tickets = 0;
            int studentTickets = 0;
            int standartTickets = 0;
            int kidTickets = 0;

            while((movie = Console.ReadLine()) != "Finish")
            {
                int spaces = int.Parse(Console.ReadLine());

                string ticket = "";
                double currMovieTickets = 0;

                while(currMovieTickets < spaces && (ticket = Console.ReadLine()) != "End")
                {
                    switch (ticket)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standartTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }

                    tickets++;
                    currMovieTickets++;
                }

                Console.WriteLine($"{movie} - {(currMovieTickets / spaces) * 100:F2}% full.");
            }

            Console.WriteLine($"Total tickets: {tickets}");
            Console.WriteLine($"{(studentTickets / tickets) * 100:F2}% student tickets.");
            Console.WriteLine($"{(standartTickets / tickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / tickets) * 100:F2}% kids tickets.");
        }
    }
}
