// COMP100 - W2020 - Week 03 
// Exercises C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Write a program that declares four variables to hold the number of eggs produced
  in a month by each of four hens. Your program should sum the eggs, and then display
  the total in dozens. For example, a total of 127 eggs is 10 dozens and 7 eggs.   */

namespace COMP100_W2020_WEEK03
{
    class Sample1
    {
        static void Main(string[] args)
        {
            Int32 firstHen;
            Int32 secondHen;
            Int32 thirdHen;
            Int32 fourthHen;

            Console.WriteLine("Please write the number of eggs produced by the first Hen:");
            firstHen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write the number of eggs produced by the second Hen:");
            secondHen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write the number of eggs produced by the third Hen:");
            thirdHen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write the number of eggs produced by the fourth Hen:");
            fourthHen = Convert.ToInt32(Console.ReadLine());

            Int32 totalEggs = firstHen + secondHen + thirdHen + fourthHen;

            Int32 numberofDozen = totalEggs / 12;
            Console.WriteLine("Total: " + totalEggs);
            Console.WriteLine("Potetential number of eggs" + numberofDozen);
            Int32 remainderofEggs = totalEggs - (numberofDozen * 12);






            //Console.WriteLine("Please write the number of eggs produced by the first Hen: ");
            //Int32 firstHen = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please write the number of eggs produced by the second Hen: ");
            //Int32 secondHen = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please write the number of eggs produced by the third Hen: ");
            //Int32 thirdHen = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please write the number of eggs produced by the fourth Hen: ");
            //Int32 fourthHen = Convert.ToInt32(Console.ReadLine());

            //int total = firstHen + secondHen + thirdHen + fourthHen;
            //// int total = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The total of eggs produced are: " + total);

            //Int32 dozen = total / 12;
            //Console.WriteLine($"A total of {dozen} dozen");
        }
    }
}
