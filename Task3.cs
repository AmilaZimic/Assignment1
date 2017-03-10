using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /*
         * Task 3:
         * Write a program that contains a function ReduceArrayByHalf,
         * which reduces the given array by half,
         * retaining the elements from the original array. 
         * The function must be void and it must be “pass by reference”.
         * Original array: 6 2 -5 5 2 6 1
         * New array: 6 2 -5
         * static void ReduceArrayByHalf(ref int[] array)
         */

        static void Main(string[] args)
        {
            int[] array = { 6, 2, -5, 5, 2, 6, 1 };

            Console.Write("Original array: ");
            PrintArray(array);

            /* The array is passed by reference so that all changes made
             *  by the function ReduceArrayByHalf are also "visible" from here.
             */

            ReduceArrayByHalf(ref array);

            Console.Write("New array: ");
            PrintArray(array);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        /**
         * A function that half the size of the given array.
         */
        static void ReduceArrayByHalf(ref int[] array)
        {
            // Create a new array, which has half the capacity
            int[] newArray = new int[array.Length / 2];

            // First copy the first part of the array
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            // The old array is now the newly constructed array
            array = newArray;
        }

        /**
         * Function that prints out the given array of integers on the console.
         * It will print them in a single line. A new line is put at the end.
         */
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
