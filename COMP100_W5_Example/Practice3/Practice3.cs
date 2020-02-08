using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

    Write a C# program that converts gallons to liters. The program should display gallons from 10 to 20 in one-gallon increments and the corresponding
    liter' equivalents. Use the relationship that 1 gallon conrtains 3.785 liter.
 
*/
namespace Practice3
{
    class Practice3
    {
        static void Main(string[] args)
        {
            double gal, lit;
            int counter;
            counter = 0;
            for (gal = 1; gal <= 10; gal++) // for loop to go to 10 gallons
            {
                lit = gal * 3.785;
                Console.WriteLine(gal + " gallons is " + lit + " liters.");
                counter++; // Increment by 1
            }
            Console.ReadLine();
            if (counter == 10)
            {
                Console.ReadLine();
                counter = 0; 
            }
        }
    }
}
