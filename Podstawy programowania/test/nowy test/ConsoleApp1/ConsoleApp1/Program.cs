using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wysokosc:");
            string h = Console.ReadLine();
            Console.WriteLine("podaj szerokosc: ");
            string w = Console.ReadLine();

            int h1 = int.Parse(h);
            int w1 = int.Parse(w);

            for (int i = 0; i < h1; i++)

            {
                for (int j = 0; j < w1; j++)
                {
                    Console.Write("#");
                }
                Console.Write("#");
            }
            Console.ReadKey();
        }

    }

}