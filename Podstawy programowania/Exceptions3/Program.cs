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
            Console.WriteLine("Podaj rozmiar tablicy: ");
            var index = int.Parse(Console.ReadLine());
            int[] tablica = new int[index];




            Console.ReadKey();
        }
    }
}
