using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int ExamMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotal = (examHour * 60) + ExamMinutes;
            int arrivalTotal = (arrivalHour * 60) + arrivalMinutes;
            int difference = examTotal - arrivalTotal;
            int hours = Math.Abs(difference / 60);
            int minutes = Math.Abs(difference % 60);

            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference > 30)  //early
            {
                Console.WriteLine("Early");
                if (minutes < 10 && hours > 0)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours before the start.");
                }
                else if (minutes >= 10 && hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes} hours before the start.");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start.");
                }
            }
            else if (difference <= 30 && difference >= 0) //on time
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{minutes} minutes before the start.");
            }
            else          //late
            {
                Console.WriteLine("Late");
                if (minutes < 10 && hours > 0)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours after the start.");
                }
                else if (minutes >= 10 && hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes} hours after the start.");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start.");
                }
            }
        }

    }
}
