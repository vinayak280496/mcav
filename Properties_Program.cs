using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class PropertiesDemo
        {
            private string name;
            private int age;

            public string Name
            {
                set
                {
                    name = value;
                }
                get
                {
                    return name;
                }
            }

            public int Age
            {
                set
                {
                    if (value > 0)
                        age = value;
                }

                get
                {
                    return age;
                }
            }

            static void Main(string[] args)
            {
                Console.Title = "file:///C:/Users/CA172007/AppData/Local/Temporary Projects/ConsoleApplication1/bin/Debug/ConsoleApplication1.EXE";
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("This Program is developed by Shubham Sajannavar");
                Console.WriteLine("Roll No : CA172007, Rani Channamma University, Belgavi");
                Console.WriteLine("---------------------------------------------------------");
                PropertiesDemo p = new PropertiesDemo();
                p.Name = "John";
                p.Age = 12;

                PropertiesDemo d = new PropertiesDemo();
                d.Name = "Rohn";
                d.Age = 14;

                Console.WriteLine("\n {0} : {1}", p.Name, p.Age);
                Console.WriteLine("\n {0} : {1}", d.Name, d.Age);
                
                Console.ReadLine();
                
            }
        }
    }
}

