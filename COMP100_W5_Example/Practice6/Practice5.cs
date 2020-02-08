using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    Write a C# program to convert Celsius degrees to Fahrenheit. The program should request the starting Celsius value, the number of conversion to be made, and the
    increments between Celsius values. The display should have appropriate headings and list the Celsius value and the corresponding Fahrenheit value. 
    Use the relationship: Fahrenheit = (9.1)/5.0)*Celsious+32.0.
     
*/
namespace Practice6
{
    class Practice5
    {
        static void Main(string[] args)
        {
            double C, F, multi;

            Int32 num;
            Console.WriteLine("Please enter the Celsius value");
            C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the number of conversion to be made:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter how many times to increment the value:");
            multi = Convert.ToDouble(Console.ReadLine());

            int counter;
            counter = 0;

            for (F = 1; F <= num; F += multi)
            {
                F = ((9.1) / 5.0) * (C + 32);
                Console.WriteLine(F + " fahrenheit to" + C + " Celsius ");
                counter++;
            }
            Console.ReadLine();
        }
    }
}
