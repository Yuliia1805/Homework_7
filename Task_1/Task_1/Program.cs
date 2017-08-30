using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
 
            Console.WriteLine("Enter any numbers in array: ");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even numbers are: ");
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }

            Console.WriteLine("Odd numbers are: ");
            for (int i = 0; i < n; i++)
            {
                if ( array[i] % 2 != 0 )
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
 
            Console.ReadLine();
        }
    }
}
