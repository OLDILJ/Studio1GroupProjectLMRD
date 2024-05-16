using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int labselect = 0;
            Console.WriteLine("Select Lab");
            switch (labselect)
            {
                case 0:
                    Lab_1();
                    break;
                case 1:
                    Lab_2();
                    break;
                case 3:
                    Lab_3();
                    break;
                case 4:
                    Lab_4();
                    break;
            }

            void Lab_1()
            {
                Console.WriteLine("Lab1");

            }
            void Lab_2()
            {
                Console.WriteLine("Lab2");

            }
            void Lab_3()
            {
                Console.WriteLine("Lab3");

            }
            void Lab_4()
            {
                Console.WriteLine("Lab4");

            }


        }

    }
}
