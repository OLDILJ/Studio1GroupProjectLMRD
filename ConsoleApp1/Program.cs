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
            labselect = Convert.ToInt32(Console.ReadLine());
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
                string temp;
                int days, hours, totalhours;
                Console.WriteLine("How many hours would you like to be converted to days and hours");
                temp = Console.ReadLine();
                totalhours = Convert.ToInt32(temp);
                days = totalhours / 24;
                hours = totalhours % 24;
                Console.WriteLine($"That is {days} Days and {hours} Hours");
                Console.ReadLine();
            }
            void Lab_4()
            {
                Console.WriteLine("Lab4");

            }


        }

    }
}
