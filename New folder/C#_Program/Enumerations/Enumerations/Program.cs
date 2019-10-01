using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerations
{
    class Program
    {
        enum CollegeDays
        {
            MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }   
        static void Main(string[] args)
        {
            Console.Title = "file:///C:/Users/CA172007/AppData/Local/Temporary Projects/ConsoleApplication1/bin/Debug/ConsoleApplication1.EXE";
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("This Program is developed by Shubham Sajannavar");
            Console.WriteLine("Roll No : CA172007, Rani Channamma University, Belgavi");
            Console.WriteLine("---------------------------------------------------------\n");

            foreach (var day in Enum.GetValues(typeof(CollegeDays)))
            {
                Console.WriteLine(">> {0} : {1}", day, (int)day);
            }
            Console.ReadKey();
        }
    }
}
