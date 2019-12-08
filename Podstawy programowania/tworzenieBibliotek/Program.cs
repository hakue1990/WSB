using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tworzenieBibliotek
{
    class Program
    { 
public struct Punkt
        {
            public int x;
            public int y;
        }
    
        static void Main(string[] args)
        {
        Punkt punkt1 = new Punkt();
            Punkt punkt2 = new Punkt();

            punkt1.x = 100;
            punkt2.x = 200;
            Console.WriteLine("Punkt1.x wynosi: {0}", punkt1.x);
            Console.WriteLine("Punkt1.y wynosi: {0}", punkt1.y);

            Console.WriteLine("Punkt2.x wynosi: {0}", punkt2.x);
            Console.WriteLine("Punkt2.y wynosi: {0}", punkt2.y);


            Console.ReadKey();
        }
    }
}
