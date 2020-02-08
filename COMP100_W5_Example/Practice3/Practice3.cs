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
            double sum = 0;
            for (int counter = 0; counter < 5; counter++)
            {
                //Int32 gal = 1;
                //gal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(sum);
                sum += 3.785;

                if (counter > 5)
                {
                    Console.WriteLine(sum);
                }
            }
            Console.WriteLine($"You have {sum}");

        }
    }
}
