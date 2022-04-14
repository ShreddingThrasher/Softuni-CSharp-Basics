using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string s = "";

            for (int i = num1; i <= num2; i++)
            {
                s = i.ToString();
                int evenSum = 0;
                int oddSUm = 0;

                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += int.Parse(s[j].ToString());
                    }
                    else
                    {
                        oddSUm += int.Parse(s[j].ToString());
                    }
                }
                if (evenSum == oddSUm)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
