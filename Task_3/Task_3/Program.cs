using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter amount of numbers in array: ");
            amount = int.Parse(Console.ReadLine());

            string[] product = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter name of {0} product: ", i + 1);
                product[i] = Console.ReadLine();
            }

            int[] price = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter price of product {0}: ", i + 1);
                price[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter maximum price: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Products that cost less than maxprice:  ");
            for (int i = 0; i < amount; i++)
            {
                if (price[i] < max)
                {
                    Console.WriteLine(product[i] + " " + price[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
