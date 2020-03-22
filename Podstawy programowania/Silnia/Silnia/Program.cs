using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            try  // blok testowania w razie podania liczby ujemnej lub "nie liczby"
            {
                uint liczba = uint.Parse(System.Console.ReadLine());        // czytanie liczby z klawiatury
                uint wynik = 1;                                     //przypisanie poczatkowej wartosci dla wyniku
                uint i;
                for (i = 2; i <= liczba; i++)                  //petla dajaca wynik = silnia z liczby
                    wynik *= i;                                //to jest to samo co zapis: wynik=wynik*i
                Console.WriteLine(liczba + "! = " + wynik);    //wyswietlenie wyniku
            }
            catch   // reakcja w razie wystąpienia błędu w blokuy try
            {
                System.Console.WriteLine("Coś nie tak z liczbą, którą podałeś :(");
            }

            Console.ReadLine();
        }
  
    }
}
