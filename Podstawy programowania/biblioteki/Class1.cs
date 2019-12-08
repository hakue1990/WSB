using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteki
{
    public class MathClass
    {
        public int Add(int num01, int num02)
        {
            return num01 + num02;
        }
        public int Kwadrat(int num01)
        {
            return num01 * num01;
        }
        public int Trójkąt()
        {
            Console.WriteLine("Podaj bok trójkąta: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość: ");
            int h = int.Parse(Console.ReadLine());
            int pole = a * h / 2;
            Console.WriteLine("pole to: ");
            Console.WriteLine(pole);
            return pole;
           
        }
    }
}
