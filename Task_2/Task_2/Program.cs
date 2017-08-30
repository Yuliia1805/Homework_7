using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter amount of numbers in array: ");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for ( int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            int min = array[0];
            int minPosition = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minPosition = i + 1;
                }
            }
            Console.WriteLine("\nThe minimum value of array is: " + min);
            Console.WriteLine("The position of minimum value of array is: " + minPosition);

            int max = array[0];
            int maxPosition = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxPosition = i + 1;
                }
            }
            Console.WriteLine("The maximum value of array is: " + max);
            Console.WriteLine("The position of maximum value of array is: " + maxPosition);

            Console.ReadLine();
        }
    }
}
