using System;

namespace T01._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerStrawberry = double.Parse(Console.ReadLine());
            double kilosBananas = double.Parse(Console.ReadLine());
            double kilosOranges = double.Parse(Console.ReadLine());
            double kilosRaspberries = double.Parse(Console.ReadLine());
            double kilosStrawberries = double.Parse(Console.ReadLine());

            double totalStrawberries = kilosStrawberries * pricePerStrawberry;
            double totalRaspberries = kilosRaspberries * (pricePerStrawberry / 2);
            double totalOranges = kilosOranges * (pricePerStrawberry / 2 * 0.60);
            double totalForBananas = kilosBananas * (pricePerStrawberry / 2 * 0.20);

            double sum = totalStrawberries + totalRaspberries + totalOranges + totalForBananas;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
