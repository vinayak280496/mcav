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
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter element at index["+i+"] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Sorted array in reverce order");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Second largest element in array : "+arr[1]);
            Console.ReadKey();
        }
    }
}
