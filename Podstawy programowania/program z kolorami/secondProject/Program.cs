using System;

namespace secondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisz program, który pobierze ile chcesz podać ulubionych kolorównastepnie wyświetli je obok sobie w tej ilosc która podałeś
            Console.WriteLine("podaj ilość kolorów: ");
            var iloscKolorow = int.Parse(Console.ReadLine());
            var kolory = "";
            for (int i = 0; i < iloscKolorow; i++)
            {
                Console.WriteLine("Podaj kolor: ");
                kolory += Console.ReadLine() + " ";

            }
            Console.WriteLine("Podane przez Ciebie kolory to: {0}", kolory);

            Console.ReadKey();
        }
    }
}

