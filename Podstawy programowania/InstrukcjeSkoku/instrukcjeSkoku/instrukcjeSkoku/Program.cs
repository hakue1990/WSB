using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcjeSkoku
{
    class Program
    {
        static void Main(string[] args)
        {

            //instrukcja break
            int a = 0;
            //while (true)
            //{
            //    if (a > 10)
            //    {
            //        break;
            //    } 
            //    Console.WriteLine(a);
            //    a++;
            //}

            for (int i = 0; i < 10; i++) // petla skonczona
            {
                if (i%2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
