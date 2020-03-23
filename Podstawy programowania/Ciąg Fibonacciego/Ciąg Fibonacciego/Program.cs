using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciąg_Fibonacciego
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("który wyraz ciągu chcesz obliczyć?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} wyrazciągu to: {1}", n, fib(n));

            Console.ReadKey();
        }
public static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }else
            {
                return fib(n - 1) + fib(n - 2);
            }
           
        }
    }
}
