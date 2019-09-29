using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ExcelWok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 101; i++)
            {
                
                Thread.Sleep(50);
                Console.Title = ("Fetching data from https://server.google.com(" + i.ToString()+")");
                
                

                if (i == 100)
                {
                    Console.WriteLine("Excel file created successfully...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Title = ("Welcome to the SBI banking application");
                }
                                
            }
            Console.ReadKey();
        }
    }
}

