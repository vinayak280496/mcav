using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        enum week { SUN,MON,TUS,WED,THR,FRI,SAT}
        static void Main(string[] args)
        {
            week num = week.SUN;
            for (int i = 0; i < 7; i++) {
                Console.WriteLine(num++);
            }
            Console.ReadKey();
        }
    }
}
