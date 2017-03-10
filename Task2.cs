using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /*
         * Task 2:
         * Write a program that counts how many odd numbers,
         * divisible by 5, are in the range [1, 1000].
         */

        static void Main(string[] args)
        {
            // Initialize the sum and set it to zero.
            int counter = 0;

            // Go through odd numbers between 1 and 1000.
            for (int i = 1; i <= 1000; i+=2)
            {
                    if (i % 5 == 0)
                        counter++;
             
            }

            // Print out the results
            Console.WriteLine("Number of integers divisible by 5 between 1 and 1000 is: " + counter);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }
    }
}