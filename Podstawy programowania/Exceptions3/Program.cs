using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             UTWÓRZ TABLICE UZYTKOWNIK PODAJE ROZMIAR TABLICY.
             UZYTKOWANIK PODAJE WIEK SWOJEJ RODZINY (KAZDA OSOBA)
             PRZYPISZ WIEK OSOB DO TABLICY JEDNOWYMIAROWEJ
             wYŚWIETL TABLICE UŻYTKOWNIKOWI A NASTĘPNIE ZADAJ PYTANIE
             JAKI JEST OSTATNI INDEX TABLICY, WYŚWIETL TEN ELEMENT NA EKRANIE W FORMACIE.
             OSTATNI ELEMENT TABLICY: ...
             WYSWIETL SREDNI WIEK RODZINY I ZABEZPIECZ PROGRAM PRZED MOZLIWYMI WYJATKAMI
             INDEX PO ZA ZAKRESU TABLICY DZIELENIE PRZEZ 0 SLOWA ZNAKI
             */


            //while (true)
            //{
            /*
            try
            {
                string tabindex; // deklaracja dlugosci tablicy
                Console.WriteLine("\nPodaj ile ma byc człornków rodziny: ");
                tabindex = Console.ReadLine(); // pobranie dlugosci tablicy od uzytkownika
                int newIntNumber = Int32.Parse(tabindex);
                uint number;
                string[] answer = new string[newIntNumber];
                double srednia = 0.0;
                for (int i = 0; i < newIntNumber; i++)
                {
                    Console.WriteLine("Podaj wiek członka rodziny: {0} ", i + 1);
                    answer[i] = Console.ReadLine();
                    int newUserAge1 = int.Parse(answer[i]);
                    srednia += newUserAge1;
                }
                for (int j = 0; j < newIntNumber; j++)
                {
                    Console.WriteLine("wiek {1} członka rodziny to: {0}", answer[j], j + 1);
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Srednia wieku userów to {0}", srednia / newIntNumber);
                    Console.ResetColor();
                Console.WriteLine("Jaki jest wiek ostatniego członka rodziny?");
        Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wiek ostatniego członka rodziny to: {0}", answer[answer.Length - 1]);
                number = uint.Parse(tabindex);
                break;

            }
            catch (FormatException)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Podaj liczbe w poprawnym formacie!");
                Console.ResetColor();

            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("wprowadzona liczba jest poza dopuszczalnym zakresem");
                Console.ResetColor();
            }
            catch (ArgumentNullException)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wartość nie mozebyc pusta");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Error {0}", e.Message);
                Console.ResetColor();
            }
        }
        // *****************************************   TROJKA PITAGOREJSKA  *************************************************************************
        */
            //Console.WriteLine("Podaj trzy cyfry:");

            //Console.WriteLine("Podaj a");
            //var a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj b");
            //var b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj c");
            //var c = int.Parse(Console.ReadLine());
            //if ((a * a + b * b == c * c))
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("to jest trojka pitagorejska");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("to nie jest trojka pitagorejska");
            //}
            //Console.ResetColor();

            //}
            //Console.WriteLine("input your age");
            //var ageAsAString = Console.ReadLine();
            //int age;
            //bool parseSucess = int.TryParse(ageAsAString, out age);
            //if (parseSucess)
            //{
            //    Console.WriteLine("your age is: {0}", age);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
            //Console.ReadKey();
            Console.WriteLine("Podaj dlugosc tablicy");
            var index = int.Parse(Console.ReadLine());
            string[] tablica = new string[index];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("podaj zawartosc tablicy");
                tablica[i] = Console.ReadLine();
            }
            for (int j = 0; j < tablica.Length; j++)
            {
                Console.WriteLine("elementy tablicy to: {0}  \t", tablica[j]
                    );
            }
            Console.ReadKey();
        }
    }
}


