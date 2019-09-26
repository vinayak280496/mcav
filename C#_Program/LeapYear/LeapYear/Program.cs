using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("This Program is to check wether the entered year is leap or not");
            Console.WriteLine("developed by Shubham Sajannavar Roll No : CA172007,\nRani Channamma University, Belgavi");
            Console.WriteLine("---------------------------------------------------------");
            try {
                Console.Write("Enter Year to check : ");
                long year = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("\n-----------------------------------------");
                if (year % 400 == 0) {
                    Console.WriteLine("\t{0} is a Leap Year",year);
                }
                else if (year % 100 == 0) {
                    Console.WriteLine("\t{0} is not a Leap Year", year);
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("\t{0} is a Leap Year", year);
                }
                else {
                    Console.WriteLine("\t{0} is not a Leap Year", year);
                }
            }
            catch(Exception ex) {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("\tEnter valid year");
            }
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();
        }
    }
}
