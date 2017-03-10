using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        /*
         * Task 10:
         * Write a function that checks whether a string contains a given substring. 
         * The function should ignore all numbers.
         * String: 1hom512e92w1rk
         * Substring: home
         * The substring is present in the string!
         * String: im2ag1ine
         * Substring: image
         * The substring is not in the string...
         * static bool ContainsSubstringIgnoreNumbers(string word, string substring)
         */

        static void Main(string[] args)
        {
            string s1 = "1hom512e92w1rk";
            string ss1 = "home";
            string s2 = "im2ag1in";
            string ss2 = "image";


            Console.Write("String: " + s1 + "\n");
            // Does it contain substring?
            Console.Write("Does it contain substring 'home'? " + ContainsSubstringIgnoreNumbers(s1, ss1) + "\n");

            Console.Write("String: " + s2 + "\n");
            // Does it contain substring?
            Console.Write("Does it contain substring 'image'? " + ContainsSubstringIgnoreNumbers(s2, ss2) + "\n");

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        static bool ContainsSubstringIgnoreNumbers(string word, string substring)
        {
            word = Regex.Replace(word, @"\d", "");

            return word.Contains(substring);
        }
    }
}
