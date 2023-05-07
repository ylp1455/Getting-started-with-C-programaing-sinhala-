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

            Console.ReadLine();
        }
    }
}
