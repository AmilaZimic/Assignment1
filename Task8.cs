using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
            /*
             * Task 8:
             * Write a function that counts how many integers are present in an array of strings.
             * String array: 25kgm2 km_25 p52v
             * Num of integers: 7
             * static int CountNumOfIntegers(ref string[] array)
             */

            static void Main(string[] args)
            {
                string[] array = { "25kgm2", "km_25", "p52v" };

                // Print the string
                Console.Write("String array: 25kgm2, km_25, p52v" + "\n");

                // Print the number of integer in string
                Console.Write("Number of integer: " + CountNumOfIntegers(ref array));

                // Stop the console from exiting immediately
                Console.ReadLine();
            }

            static int CountNumOfIntegers(ref string[] array)
            {
                char[] character = string.Join(string.Empty, array).ToCharArray();
                int count = 0;
                for (int i = 0; i < character.Length; i++)
                    if (Char.IsDigit(character[i]))
                        count++;
                return count;
            }
        }
    }
