using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st Number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number :");
                int num2 = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine("Addition of " + num1 + " and " + num2 + " is " + (num1 + num2));
                Console.WriteLine("Substraction of " + num1 + " and " + num2 + " is " + (num1 - num2));
                Console.WriteLine("Multiplication of " + num1 + " and " + num2 + " is " + (num1 * num2));
                Console.WriteLine("Division of " + num1 + " and " + num2 + " is " + (num1 / num2));
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
