using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("What's ur name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your name's: {0}", name);
           
            // Napisz program który pobiera od usera boki i liczy pole prostokąta

            Console.Write("podaj bok a: ");
            string a = Console.ReadLine();
            Console.Write("podaj bok b: ");
            string b = Console.ReadLine();
            int result =  int.Parse(a) * int.Parse(b);
            Console.WriteLine("bok prostokąta wynosi: {0}", result);




            Console.ReadKey();
        }
    }
}
