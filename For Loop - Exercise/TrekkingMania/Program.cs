using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musalaPeople = 0;
            int monblanPeople = 0;
            int kalimanjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            double totalPeople = 0;
            int groupPeople;

            for (int i = 0; i < groups; i++)
            {
                groupPeople = int.Parse(Console.ReadLine());

                if(groupPeople <= 5)
                {
                    musalaPeople += groupPeople;
                }
                else if(groupPeople <= 12)
                {
                    monblanPeople += groupPeople;
                }
                else if(groupPeople <= 25)
                {
                    kalimanjaroPeople += groupPeople;
                }
                else if(groupPeople <= 40)
                {
                    k2People += groupPeople;
                }
                else
                {
                    everestPeople += groupPeople;
                }

                totalPeople += groupPeople;
            }

            Console.WriteLine($"{(musalaPeople / totalPeople) * 100:F2}%");
            Console.WriteLine($"{(monblanPeople / totalPeople) * 100:F2}%");
            Console.WriteLine($"{(kalimanjaroPeople / totalPeople) * 100:F2}%");
            Console.WriteLine($"{(k2People / totalPeople) * 100:F2}%");
            Console.WriteLine($"{(everestPeople / totalPeople) * 100:F2}%");
        }
    }
}
