using System;


namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
                Console.WriteLine("Podaj dzień tygodnia (1-5)");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }

            switch (x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new Exception("masz już weekend sobota :D");
                case 7:
                    throw new Exception("masz już weekend niedziela :D");
                default:
                    throw new ArgumentOutOfRangeException("liczba po za zakresem"); // dodawanie wlasnych wyjatków błędów
            }
            Console.ReadKey();
        }
    }
}
