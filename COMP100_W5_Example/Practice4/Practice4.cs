using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    Write a C# program that converts feet to meters. The program should display feet from 3 to 30 in three-foot increments and
    the corresponding meter equivalents. Use the relationship that 1 meter is equivalent to 3.28 feet.
     
*/
namespace Practice4
{
    class Practice4
    {
        static void Main(string[] args)
        {
            double meters, feet;
            int counter;
            counter = 0;
            for (meters = 3; meters <= 30; meters+=3) // for loop
            {
                feet = meters * 3.28;
                Console.WriteLine(meters + " meter is " + feet + " feet.");
                counter++; 
            }
            Console.ReadLine();
        }
    }
}
