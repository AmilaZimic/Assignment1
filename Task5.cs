using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        /*
         * Task 5:
         * Write a function that checks whether a given birthday, given as a day and month, 
         * has been or will be in this year. 
         * Use a function that gets the system date and checks the given date with it.
         * Birthday: 28 1
         * Current date: 24 2         * Birthday already passed!         * static bool CheckWhetherBirthdayPassed(int day, int month)
         */

        static void Main(string[] args)
        {
            // Let the user type date (day and month)

            Console.Write("Enter day: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            int todayD = today.Day;
            int todayM = today.Month;

            if (d < todayD && m <= todayM)
            {
                // Birthday passed
                Console.Write("Birthday passed!" + "\n");
            }

            else
                // Birthday not passed
                Console.Write("Birthday not passed!" + "\n");

            // Stop the console from exiting immediately
            Console.ReadLine();

        }
    }
}