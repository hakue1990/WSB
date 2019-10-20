using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyprogramowania
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAPISZ PROGRAM KTÓRY, ZA POMOCĄ PĘTLI FOR ZSUMUJE LICZBY NIEPARZYSTE Z RPZEDZIAŁU
            // <1;10>

            //int suma = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%2 != 0)
            //    {
            //        suma += i;

            //    }
            //}
            //Console.WriteLine("suma liczb nieparzystych z przedziału <od 1:10> wynosi: {0}", suma);

            // Napisz program który wyświetli duże litery alfabetu od A do Z oraz od Z do A z wykorzystaniem
            // pętli for np: A,B,C, .... , Z.\
            // lub Z, Y, X ... A.

            //char znak = 'A';

            //for (; znak <= 'Z'; znak++)
            //{
            //    if (znak == 'Z')
            //    {
            //        Console.WriteLine("{0}", znak + ". \n");
            //    }
            //    else
            //    {
            //        Console.Write("{0}", znak);
            //    }
            //}
            //for (znak = 'Z'; znak >= 'A'; znak--)
            //{
            //    if (znak == 'A')
            //    {
            //        Console.WriteLine("{0}", znak + ". \n");
            //    }
            //    else
            //    {
            //        Console.Write("{0}", znak);
            //    }
            //}

            //Napisz program który, za pomocą instrukcji while dla danych wartości x zmieniających się
            //w Przedziale od 0-10 oblicza wartość w funkcji y = 4*x
            //int x = 0;
            //int y;
            //while (x <=10)
            //{
            //    y = 4 * x;
            //    Console.WriteLine("x= {0}\ty={1}", x, y);

            //    x++;
            //}

            //NAPISZ PROGRAM KTÓRY ZA POMOCĄ INSTRUKCJI WHILE DLA DANYCH WARTOŚCI X ZMIENIAJĄCYCH SIĘ W PRZEDZIALE
            // OD <1;50> OBLICZY ICH SUME;

            //int x = 1;
            //int suma = 0;

            //while (x <= 50)
            //{
            //    suma += x;
            //    x++;
            //    Console.WriteLine("x= {0} \t suma={1}", x, suma);

            //}


            //Użytkownik podaje swój wiek z klawiatury z przedziału <1;120>
            //wykorzystaj instrukcję do while do prawidłowego podania danych.

            //int wiek;
            //do
            //{
            //    Console.WriteLine("podaj wiek");
            //    wiek = int.Parse(Console.ReadLine());

            //} while (wiek >= 120 || wiek < 1);
            //Console.WriteLine("twój wiek to {0}", wiek);


            //Wyświetl tabliczke mnożenia za pomocą dwóch pętli do while
            int row1 = 1;
            int col1 = 1;
            int tabliczka;

            do
            {
                do
                {
                    Console.WriteLine();
                    col1++;
                    tabliczka = row1 * col1;
                    Console.WriteLine(row1 + "\t");
                } while (col1<=10);
                row1++;
                Console.Write(col1 + "\t");
            } while (row1 <=10);

        


            Console.ReadKey();
        }
    }
}