using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /*
         * Task 1:
         * Write a C# program that takes N as input and then prints out the 
         *  x∈[1,N] numbers from the f(x)=x^3 + 5 sequence.
         * N: 5
         * Sequence: 6 13 32 69 130
         */

        static void Main(string[] args)
        {
            // Let the user type in the value of N
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Print the sequence
            Console.Write("Sequence: ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write((i * i * i + 5) + " ");
            }

            // Stop the console from exiting immediately
            Console.ReadLine();
        }
    }
}


