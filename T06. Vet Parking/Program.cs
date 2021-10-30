using System;

namespace T06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                double totalForCurrentDay = 0;
                for (int currentHour = 1; currentHour <= hours; currentHour++)
                {
                    if (currentDay % 2 == 0 && currentHour % 2 != 0)
                    {
                        totalForCurrentDay += 2.50;
                        total += 2.50;
                    }
                    else if (currentDay % 2 != 0 && currentHour % 2 == 0)
                    {
                        totalForCurrentDay += 1.25;
                        total += 1.25;
                    }
                    else
                    {
                        totalForCurrentDay += 1;
                        total += 1;
                    }
                }
                Console.WriteLine($"Day: {currentDay} - {totalForCurrentDay:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
