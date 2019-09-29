using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len;
            char[] arr;
            char ch;

            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            len = str.Length;

            arr = str.ToCharArray(0,len);
            Console.WriteLine("After Conversion");

            for (i = 0; i < len; i++) {
                ch=arr[i];
                if (Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else {
                    Console.Write(Char.ToLower(ch));
                }
            
            }

                Console.ReadKey();
        }
    }
}

