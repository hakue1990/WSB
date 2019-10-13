using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Set number of colors:");
            //var colorNumbers = int.Parse(Console.ReadLine());
            //var colors = "";

            //for (int i = 0; i < colorNumbers; i++)
            //{
            //    Console.WriteLine("Yours color is:");
            //    colors += Console.ReadLine() + " ";
            //}
            //Console.WriteLine(colors);


            Console.WriteLine("How many favorit car brands do you have: ");

            var brandNumber = int.Parse(Console.ReadLine());
            var cars = " ";
            Console.ForegroundColor = ConsoleColor.Red;
            

            for (int i = 1; i < brandNumber + 1; i++)
            {
                
                Console.WriteLine("Enter a car brand {0}: ", i);
     
                    cars += Console.ReadLine() + " ";
             

                
            }
            Console.ResetColor();
            Console.WriteLine(cars);
            
            Console.ReadKey();
            Console.Clear();

        }
    }
}
