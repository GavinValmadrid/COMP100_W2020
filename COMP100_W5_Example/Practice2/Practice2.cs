using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    Write a program to produce a table that starts at a Celsius value of -10 and ends with a Celcius value of 60, in increments of ten degrees.

 */

namespace Practice2
{
    class Practice2
    {
        static void Main(string[] args)
        {

            int sum = -10;
            for (int counter = 0; counter < 8; counter++)
            {
                Console.WriteLine($"{sum} C");
                sum += 10;

                if (counter > 8)
                {
                    sum += -10;
                }

            }
            Console.WriteLine($"{sum} C");
            
    }
}
