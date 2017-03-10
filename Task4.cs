using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        /*
         * Task 4:
         * Write a function that counts how many months have passed from a given date, passed in to the function. 
         * The date only includes the month and the year.
         * Date: 2 2016
         * Months passed: 12
         * static int GetNumberOfMonthsPassed(int month, int year)
         */

        static void Main(string[] args)
        {
            // Let the user type date (month and year)

            Console.Write("Enter month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            int todayM = today.Month;
            int todayY = today.Year;

            int result = 0;

            if (m > todayM)
            {
                result = (todayY - y) * 12 - (m - todayM);
            }

            else
            {
                result = (todayY - y) * 12 + (todayM - m);
            }

            // Months passed
            Console.Write("Months passed: " + result + "\n");

            // Stop the console from exiting immediately
            Console.ReadLine();
        }
    }
}


