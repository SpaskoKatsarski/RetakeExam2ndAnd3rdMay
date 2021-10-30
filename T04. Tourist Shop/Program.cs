using System;

namespace T04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();

            double sum = 0;
            int productsBought = 0;
            bool flag = false;

            while (product != "Stop")
            {
                double priceForProduct = double.Parse(Console.ReadLine());
                productsBought++;
                if (productsBought % 3 == 0)
                {
                    priceForProduct /= 2;

                }
                sum += priceForProduct;
                if (sum > budget)
                {
                    flag = true;
                    break;
                }
                product = Console.ReadLine();
            }
            if (flag)
            {
                double neededMoney = sum - budget;
                Console.WriteLine($"You don't have enough money!\nYou need {neededMoney:f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {productsBought} products for {sum:f2} leva.");
            }
        }
    }
}
