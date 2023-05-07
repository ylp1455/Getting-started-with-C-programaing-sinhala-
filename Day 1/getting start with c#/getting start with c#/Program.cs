using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_start_with_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to print your name.
            Console.WriteLine("C# sinhala tutorial");

            // Write a C# program to draw a pyramid using stars.
            Console.WriteLine("     *  ");
            Console.WriteLine("  *    * ");
            Console.WriteLine("*    *   *");

            // Write a C# program to print following pattern:
            // *
            // * *
            // * * *
            // * * * *
            // * * * * *
            Console.WriteLine("*");
            Console.WriteLine("* *");
            Console.WriteLine("* * *");
            Console.WriteLine("* * * *");
            Console.WriteLine("* * * * *");

            // Write a C# program to print following pattern:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4
            // 1 2 3 4 5
            Console.WriteLine("1");
            Console.WriteLine("1 2");
            Console.WriteLine("1 2 3");
            Console.WriteLine("1 2 3 4");
            Console.WriteLine("1 2 3 4 5");

            // How to comment in C#:
            // This is a single line comment.
            /* This
               is 
               multiline
               comment. */

            // Variables and operators:
            // Write a C# program to add two numbers and display the answer.
            int num1 = 26;
            int num2 = 35;
            int ans = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + ans);

            // Write a C# program to accept two numbers from from user and display the answer as the the out put .
            string num1;
            string num2; 
            int no1; 
            int no2;
            Console.WriteLine("Enter first number ");
            num1 = Console.ReadLine();
            no1 = Convert.num1 toint32(num1);

            Console.WriteLine("Enter scond number ");
            num1 = Console.ReadLine();
            no2 = Convert .ToInt32 (num2);

            ans = num1 + no2;

            Console.WriteLine("Addition is = ", ans);

            Console.ReadLine();
        }
    }
}
