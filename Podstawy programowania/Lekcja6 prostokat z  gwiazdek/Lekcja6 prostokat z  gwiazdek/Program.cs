using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6_prostokat_z__gwiazdek
{
    class Program
    {
        static void Main(string[] args)
        {

            //NAPISZ PROGRAM KTORY WYSWIETLI PROSTOKAD TO WYSOKOSCI I SZEROKOSCI POBRANEJ OD USERA.

            Console.WriteLine("Podaj wysokość: ");
            string h = Console.ReadLine();
            Console.WriteLine("Podaj szerokość: ");
            var w = Console.ReadLine();

            int height = int.Parse(h);
            int width = int.Parse(w);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    Console.Write("(. )( .)");
                }
                Console.WriteLine("(. )( .)");
            }



            //GRA W ZGADYWANIE LICZBY WYLOSOWANEJ PRZEZ KOMPUTER

            //Console.WriteLine("Wylosowałem liczbe x w zakresie - 10  ");
            //Random rnd = new Random();
            //int los = rnd.Next(1, 11);
            //int mojaLiczba;
            //int time = 0;

            //do
            //{
            //    time++;
            //    Console.WriteLine("podaj jej wartość:");
            //    mojaLiczba = int.Parse(Console.ReadLine());
            //    if (mojaLiczba > los)
            //    {
            //        Console.WriteLine("zbyt duża wartość - keep trying");
            //    }
            //    else if (mojaLiczba < los)
            //    {
            //        Console.WriteLine("zbyt mala wartosc - keep trying");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Welldone you found a correct number at {0} time", time);
            //    }
            //} while (los != mojaLiczba);





            Console.ReadKey();
        }
    }
}
