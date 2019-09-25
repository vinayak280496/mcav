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
            Console.Title = "file:///C:/Users/CA172007/AppData/Local/Temporary Projects/ConsoleApplication1/bin/Debug/ConsoleApplication1.EXE";
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("This Program is developed by Shubham Sajannavar");
            Console.WriteLine("Roll No : CA172007, Rani Channamma University, Belgavi");
            Console.WriteLine("---------------------------------------------------------");

            string str;
            char[] arr1;
            int i,len;
            len = 0;
            char ch;

            try
            {

                Console.WriteLine("\nEnter a String :");
                str = Console.ReadLine();

                len = str.Length;

                arr1 = str.ToCharArray(0, len);

                Console.WriteLine("\nAfter Conversion");
                Console.WriteLine("---------------------------------------------------------");

                for (i = 0; i < len; i++)
                {
                    ch = arr1[i];
                    if (Char.IsLower(ch))
                    {
                        Console.Write(Char.ToUpper(ch));
                    }
                    else
                    {
                        Console.Write(Char.ToLower(ch));
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
