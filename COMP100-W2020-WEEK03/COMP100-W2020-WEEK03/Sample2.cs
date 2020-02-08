using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_W2020_WEEK03
{
    class Sample2
    {



        /*  Write a program that prompts the user for a name, Social Insurance Number, hourly pay rate
            and the number of hourse worked. In an attractive format display all the input data as
            well as the following:

            Gross pay is hourly pay rate times hours worked

            Federal tax is 15% of gross pay

            Provincial tax is 10% of gross pay

            Net pay is gross minus federal and privincial taxes

            p.s - use STRING when declaring name and SIN     
             
            

        */






        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter your social insurance number: ");
            string SIN = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter your hourly pay: ");
            double hourlyPay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the number of hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Payroll sumarry for:" + name);

            Console.WriteLine(SIN);

            Console.WriteLine($"You worked for {hoursWorked} at {hourlyPay:C} per hour");

            string a = "\n";
            Console.WriteLine(a);

            double grossPay = hourlyPay * hoursWorked;
            Console.WriteLine($"Gross Pay: ${grossPay,20:C}");

            double federalTax = grossPay * 0.15;
            Console.WriteLine($"Federal Tax: {federalTax,18:C}");

            double provincialTax = grossPay * 0.10;
            Console.WriteLine($"Provincial tax: {grossPay,16:C}");

            double netPay = grossPay - (federalTax + provincialTax);
            Console.WriteLine($"Net Pay: {netPay,24:C}");
        }
    }
}
