using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        /*
         * Task 6:
         * Write a function that returns the extension of a given filename.
         * Filename: got_S6E9.avi
         * Extension: avi
         * static string GetExtension(string filename)
         */

        static void Main(string[] args)
        {
            string filename = "got_S6E9.avi";

            // Print the file name
            Console.Write("Filename: " + filename + "\n");

            // Print the file extension
            Console.Write("Extension: " + GetExtension(filename));

            // Stop the console from exiting immediately
            Console.ReadLine();

        }

        /**
         * Function that gets and returns extension of the file name.
         */

        static string GetExtension(string filename)
        {
            return Path.GetExtension(filename);
        }
    }
}
