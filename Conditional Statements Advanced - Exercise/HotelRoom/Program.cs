using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceApartment = nights;
            double priceStudio = nights;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio *= 50;
                    priceApartment *= 65;
                    if (nights > 7 && nights <= 14)
                    {
                        priceStudio *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        priceStudio *= 0.70;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio *= 75.20;
                    priceApartment *= 68.70;
                    if (nights > 14)
                    {
                        priceStudio *= 0.80;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio *= 76;
                    priceApartment *= 77;
                    break;
            }
            if (nights > 14)
            {
                priceApartment *= 0.90;
            }
            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
