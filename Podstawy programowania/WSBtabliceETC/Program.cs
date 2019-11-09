using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBtabliceETC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("tablice");
            //int[] tab = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int count = 0;
            //Console.WriteLine("pierwszy element tablicy to {0}",tab[0]);

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    Console.WriteLine("{0} Index tablicy ma wartość {1}", count, tab[i]);
            //    count++;
            //}
            //int count1 = 0;
            //foreach (int item in tab)
            //{
            //    Console.WriteLine("element {0} ma wartość w tablicy: {1}", count1, item);
            //    count1++;

            //}
            //user podaje z klawiatury 3 swoje ulubione kolory przypisz je do tablicy i wyświetl na ekranie w formacie kolor1: value etc..
            // do przypisanie kolorow wykorzystaj petle for.
            //args do wyswietlenia kolorow z tablicy wykorzystaj petle while


            //string[] colorTab = new string[3];
            //int j = 1;
            //for (int i = 0; i < colorTab.Length; i++)
            //{
            //    Console.WriteLine("Podaj swój kolor");

            //    colorTab[i] = Console.ReadLine();

            //}

            //while (j<=3)
            //{
            //    Console.ReadKey();
            //    Console.WriteLine("kolor {0} to {1}",j, colorTab[j-1]);
            //    j++;
            //}

            //Tablica prostokątna

            //int[,] tablicaProstokatna = new int[,]
            //{
            //    {1,2,3,4 },
            //    {5,6,7,8 },
            //    {9,10,11,12},
            //    {13,14,15,16},
            //    {17,18,19,20}
            //};

            //for (int i = 0; i < tablicaProstokatna.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tablicaProstokatna.GetLength(1); j++)
            //    {
            //        Console.Write("\t" + tablicaProstokatna[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //TABLICA WIELOWYMIAROWA

            int[][] number = new int[4][]
            {
                new int[] { 1,2},
                new int[] { 1,2},
                new int[] { 1,2},
                new int[] { 7,3}

            };

            //for (int i = 0; i < number.GetLength(0); i++)
            //{
            //    for (int j = 0; j < number[i].Length; j++)
            //    {
            //        Console.Write(number[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            foreach (int item in number[0])
            {

                foreach (int item1 in number[1])
                {
                    Console.Write(number[0][0]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
