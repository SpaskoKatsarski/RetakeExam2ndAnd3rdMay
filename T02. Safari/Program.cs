using System;

namespace T02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FUEL_PER_LITER = 2.10;
            const double PRICE_FOR_TOUR_GUIDE = 100;

            double budget = double.Parse(Console.ReadLine());
            double neededFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double priceForFuel = neededFuel * PRICE_FUEL_PER_LITER;
            double total = priceForFuel + PRICE_FOR_TOUR_GUIDE;

            if (day == "Saturday")
            {
                total *= 0.90;
            }
            else
            {
                total *= 0.80;
            }
            double difference = Math.Abs(total - budget);
            if (budget >= total)
            {
                Console.WriteLine($"Safari time! Money left: {difference:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {difference:f2} lv.");
            }
        }
    }
}
