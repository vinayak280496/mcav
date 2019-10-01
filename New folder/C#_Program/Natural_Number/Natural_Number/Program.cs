using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Natural_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int add=0;
            Console.WriteLine("First 10 Natural Numbers");
            Console.WriteLine("-------------------------------");
            for(int i=1; i<=10; i++){
                Console.WriteLine(+i);
                add = add + i;
                if (i == 10) {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Addition of above numbers are : "+add);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******************************************************************");
            Console.WriteLine("* Program is developed by CA172007 (Shubham Sajannavar) MCA 5th. *");
            Console.WriteLine("******************************************************************");
            Console.ReadKey();            
        }
    }
}
