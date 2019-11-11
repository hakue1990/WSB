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


            while (true)
            {

                try
                {
                    string tabindex; // deklaracja dlugosci tablicy
                    Console.WriteLine("\nPodaj ile ma byc elementów tablicy: ");
                    tabindex = Console.ReadLine(); // pobranie dlugosci tablicy od uzytkownika
                    int newIntNumber = Int32.Parse(tabindex);
                    uint number;
                    string[] answer = new string[newIntNumber];
                    for (int i = 0; i < newIntNumber; i++)
                    {
                        Console.WriteLine("Podaj jakie to ma być elementy tablicy: {0} ", i + 1);
                        answer[i] = Console.ReadLine();

                    }
                    for (int j = 0; j < newIntNumber; j++)
                    {
                        Console.WriteLine("element {1} to: {0}", answer[j], j + 1);

                    }
                    Console.WriteLine("jaki jest ostatni element tablicy?");
            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ostatni element to: {0}", answer[answer.Length - 1]);
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
            Console.ReadKey();
        }
    }
}

