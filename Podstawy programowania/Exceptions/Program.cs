using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using secondName;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
           //System.Console.WriteLine("WSB!");

            firstName.namespace_1 ob = new firstName.namespace_1();
            ob.method();

            namespace_2.method();

            Outer.Middle.Inner.Prog ob3 = new Outer.Middle.Inner.Prog(); // tu ten temat
            Console.WriteLine("suma wynosi: {0}", ob3.Add(3,4));
            System.Console.ReadKey();
        }
    }
}
namespace firstName
{
    class namespace_1
    {
        public void method()
        {
            Console.WriteLine("pierwsza przestrzen nazw");
        }
    }
}

namespace secondName
{
    static class namespace_2
    {
        public static void method()
        {
            Console.WriteLine("druga przestrzen nazw");
        }
    }
}

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}