using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.  write a C# program to calculate the gross pay of an employee
            // gross pay = hourly rate  * hours worked

            double hours;
            double rate;
            double grossPay;

            Console.WriteLine("Enter the hours wroked");
            hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate");
            rate = double.Parse(Console.ReadLine());

            grossPay = hours * rate;

            Console.WriteLine("Gross pay is " + grossPay);


            Console.ReadLine();
        }
    }
}
