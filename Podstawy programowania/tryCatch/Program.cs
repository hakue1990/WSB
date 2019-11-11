
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            string str;
            while (true)
            {
                Console.ResetColor();
                    Console.WriteLine("\nPodaj liczbe całkowitą: ");
                    str = Console.ReadLine();
                try
                {
                    number = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podaj liczbe w poprawnym formacie!");

                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Wartość nie mozebyc pusta");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Error {0}", e.Message);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("podajliczbe całkowita: {0}", number);
            Console.ReadKey();
        }
    }
}
