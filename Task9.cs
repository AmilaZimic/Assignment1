using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        /*
         * Task 9:
         * Write a function that removes all numbers from a given string.
         * String: 25kgm2-kmp52!v
         * New string: kgm-kmp!v
         * String: th1s1ssp4rt4
         * New string: thsssprt
         * static string RemoveNumbers(string s)
         */

        static void Main(string[] args)
        {
            string input1 = "25kgm2-kmp52!v";
            string output1 = RemoveNumbers(input1);
            string input2 = "th1s1ssp4rt4";
            string output2 = RemoveNumbers(input2);


            // Print the string
            Console.Write("String array: " + input1 + "\n");
            // Print the number of integer in string
            Console.Write("New string: " + output1 + "\n");

            // Print the string
            Console.Write("String array: " + input2 + "\n");
            // Print the number of integer in string
            Console.Write("New string: " + output2);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        static string RemoveNumbers(string n)
        {
            return Regex.Replace(n, @"\d", "");
        }
    }
}
