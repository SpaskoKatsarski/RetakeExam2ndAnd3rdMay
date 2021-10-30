using System;

namespace T05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    sum1++;
                }
                if (currentNumber % 3 == 0)
                {
                    sum2++;
                }
                if (currentNumber % 4 == 0)
                {
                    sum3++;
                }
            }
            double p1 = (double)sum1 / n * 100;
            double p2 = (double)sum2 / n * 100;
            double p3 = (double)sum3 / n * 100;
            Console.WriteLine($"{p1:f2}%\n{p2:f2}%\n{p3:f2}%");
        }
    }
}
