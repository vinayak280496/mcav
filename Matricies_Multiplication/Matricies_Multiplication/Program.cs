using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matricies_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title=("Matix Multiplication");
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];

            Console.WriteLine("Enter Element for 1st Array ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix one element are stored.\n");
            Console.WriteLine("Enter Element for 2nd Array.");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix two element are stored.");
            Console.WriteLine("First Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + mat1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Array");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + mat2[i, j]);
                }
                Console.WriteLine();
            }





                Console.ReadKey();
        }
    }
}
