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
            Console.Title = "Natural Numbers and their Sum";
            int i, sum=0;
            for (i = 1; i <= 10; i++) {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("Sum of first 10 natural numbers are : "+sum);
            Console.ReadKey();
        }
    }
}
