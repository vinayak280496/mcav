using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                int num1 = Convert.ToInt32(args[0]);
                int num2 = Convert.ToInt32(args[1]);

                int sum = num1 + num2;

                Console.WriteLine("CommandLine Args are : " + num1 + " and " + num2 + ".");
                Console.WriteLine("Addition of "+num1+" and "+num2+" : "+sum);
            }
            else {
                Console.WriteLine("More then two ares are passed.");
            }
            Console.ReadKey();

            
        }

    }
}
