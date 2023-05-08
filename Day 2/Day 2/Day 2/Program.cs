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

            /*

            /// Make a variable called marks 
            /// Enter soe value to the marks
            /// Accroding to vaue ogive the results
            ///     less than 50 - bad
            ///     equall to 50 - ok
            ///     greater than 50 - execlent

            double marks;

            Console.WriteLine("Enter the makrs of student");
            
            marks = double.Parse(Console.ReadLine());

            if (marks < 50)
            {
                Console.WriteLine("Bad");
            }
            else if (marks == 50)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Excellent");
            }

            */


            /*
             Make a code to display the given Nuber 1 to 10
            EX:
                if user enterd 1 as input , output "You enterd One"
                if user enterd 2 as input , output "You enterd Two"
                -------------------------------------------------
                -------------------------------------------------
                if user enterd 10 as input , output "You enterd Ten"
                
                

            
            int num;
            Console.WriteLine("Enter a number one to ten");
            num = int.Parse(Console.ReadLine());

            switch (num) 
            {

                case 0:
                    Console.WriteLine("You enterd zero");
                    break;

                case 1:
                    Console.WriteLine("You enterd One");
                    break;

                case 2:
                    Console.WriteLine("You enterd Two");
                    break;

                case 3:
                    Console.WriteLine("You enterd Three");
                    break;
                case 4:
                    Console.WriteLine("You enterd Four");
                    break;
                case 5:
                    Console.WriteLine("You enterd Five ");
                    break;
                case 6:
                    Console.WriteLine("You enterd Six");
                    break;
                case 7:
                    Console.WriteLine("You enterd Seven");
                    break;
                case 8:
                    Console.WriteLine("You enterd Eight");
                    break;
                case 9:
                    Console.WriteLine("You enterd Nine");
                    break;
                case 10:
                    Console.WriteLine("You enterd ten");
                    break;
               

            }
            */

            /*
             
            loops 

            C# has 3 kind of loops 
                1 while loop
                2 for loop
                3 do while loop

             


            
            while (num <= 1000) 
            {
                Console.WriteLine(num);
                num++;
            }

            
            int num = 0;
            do
            {

                Console.WriteLine(num);
                num++;

            } while (num <= 1000);
            */

            

            for (int i = 0; i < 1001; i++)
            { Console.WriteLine(i); }

            Console.ReadLine();
        }
    }
}
