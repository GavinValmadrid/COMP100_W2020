using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    Write a program to print the numbers 2 to 10 in increments of two. The output of your program should be 2, 4, 6, 8, 10.
     
*/

namespace COMP100_W5_Example
{
    class Practice1
    {
        static void Main(string[] args)
        {
            int sum = 2;
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine(sum);
                sum += 2;
            }
            Console.WriteLine($"{sum}");

        }
    }
}
