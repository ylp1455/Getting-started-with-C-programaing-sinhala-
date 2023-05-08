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

            /*
            //3.  write a C# program to calculate the gross pay of an employee
            // gross pay = hourly rate  * hours worked
            

            double hours;
            double rate;
            double grossPay;

            Console.WriteLine("Enter the hours worked");
            hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate");
            rate = double.Parse(Console.ReadLine());

            grossPay = hours * rate;

            Console.WriteLine("Gross pay is " + grossPay);
            */


            /*


            ///Write a C# program that accept monthly rental of a house , average electricity , telephone 
            ///and water bill for a month calculate the expenditure fo one year

            double houseRent ,waterBill, electricityBill, tlephoneBill , avg , expens;

            Console.WriteLine("Enter the amount of house rent ");
            houseRent = double.Parse(Console.ReadLine());



            Console.WriteLine("Enter the amount of water bill ");
            waterBill = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of water bill ");
            electricityBill = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of water bill ");
            tlephoneBill = double.Parse(Console.ReadLine());

            avg = (tlephoneBill + electricityBill + waterBill);

            expens = avg * 12 + (12*houseRent);

            Console.WriteLine("Expenditure for one year is : " + expens);
            */



            /*
             
                * Make an integer Variable Called Number
                * Assign some values to the variables
                * If the value is greater than 50 , " output number is greater than 50"
             
             */

            /*
            int Number;

            Number = 200;

            if (Number > 50)
            { Console.WriteLine("The number is greater than 50"); }           
            
            else { Console.WriteLine("The number is less than 50"); }

            */

            /// Make a variable called marks 
            /// Enter soe value to the marks
            /// Accroding to vaue ogive the results
            ///     less than 50 - bad
            ///     equall to 50 - ok
            ///     greater than 50 - execlent

            double marks;

            Console.WriteLine("Eneter the makrs of student");
            
            marks = double.Parse(Console.ReadLine());

            if (marks < 50) { Console.WriteLine("Bad"); }
            else if (marks == 50) { Console.WriteLine("Ok"); }
            else { Console.WriteLine("Excelent"); }

            Console.ReadLine();
        }
    }
}
