using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{

    class Program
    {

        /*
         * Task 7:
         * Write a function that checks whether a given positive number contains only ones and zeroes.
         * Number: 101011
         * CanBeBinary: true
         * Number: 101510
         * CanBeBinary: false
         * static bool CanBeBinary(int number)
         */

        static void Main(string[] args)
        {
            // Let the user type in the value of number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Can be binary?
            Console.Write("Can be binary: " + CanBeBinary(number));

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        /**
         * Function that checks whether a number binary or not.
         */

        static bool CanBeBinary(int number)
        {
            bool isBinary = true;

            int copyOfNumber = number;

            while (copyOfNumber != 0)
            {
                int temp = copyOfNumber % 10;   //Gives last digit of the number

                if (temp > 1)
                {
                    isBinary = false;
                    break;
                }
                else
                {
                    copyOfNumber = copyOfNumber / 10;    //Removes last digit from the number
                }
            }

            return isBinary;
        }
    }
}

