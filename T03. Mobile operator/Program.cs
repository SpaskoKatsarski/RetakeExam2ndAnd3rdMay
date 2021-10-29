using System;

namespace T03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            string type = Console.ReadLine();
            string option = Console.ReadLine();
            int monthsToPay = int.Parse(Console.ReadLine());

            double tax = 0;

            if (year == "one")
            {
                if (type == "Small")
                {
                    tax += 9.98;
                }
                else if (type == "Middle")
                {
                    tax += 18.99;
                }
                else if (type == "Large")
                {
                    tax += 25.98;
                }
                else
                {
                    tax += 35.99;
                }
            }
            else
            {
                if (type == "Small")
                {
                    tax += 8.58;
                }
                else if (type == "Middle")
                {
                    tax += 17.09;
                }
                else if (type == "Large")
                {
                    tax += 23.59;
                }
                else
                {
                    tax += 31.79;
                }
            }
            if (option == "yes")
            {
                if (tax <= 10)
                {
                    tax += 5.50;
                }
                else if (tax <= 30)
                {
                    tax += 4.35;
                }
                else if (tax > 30)
                {
                    tax += 3.85;
                }
            }
            if (year == "two")
            {
                tax -= tax * 3.75 / 100;
            }

            double total = monthsToPay * tax;
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
