using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteki;

namespace biblioteka1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass x = new MathClass();
            
            Console.WriteLine(x.Add(1, 3));
            Console.WriteLine(x.Add(1, 3));
            x.Trójkąt();
            Console.ReadKey();
        }
    }
}
