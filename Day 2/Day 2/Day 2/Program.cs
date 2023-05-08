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

            Console.WriteLine("Enter the hours wroked");
            hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate");
            rate = double.Parse(Console.ReadLine());

            grossPay = hours * rate;

            Console.WriteLine("Gross pay is " + grossPay);
            */





            ///Write a C# program that accept monthly rental of a house , average electricity , telephone 
            ///and water bill for a month calculate the expenditure fo one year

            double waterBill, electricityBill, tlephoneBill , avg , expens;

            Console.WriteLine("Enter the amount of water bill ");
            waterBill = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of water bill ");
            electricityBill = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of water bill ");
            tlephoneBill = double.Parse(Console.ReadLine());

            avg = (tlephoneBill + electricityBill + waterBill)/3;

            expens = avg * 12;

            Console.WriteLine("Expenditure for one year is : " + expens);

            Console.ReadLine();
        }
    }
}
