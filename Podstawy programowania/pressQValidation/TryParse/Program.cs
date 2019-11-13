using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodCounter = 0, badCounter = 0;
            string input = "";
            do
            {
                Console.WriteLine("Enter a number 0 - 10. press q to Quit");
                input = Console.ReadLine();
                int number;
                if (!input.ToUpper().Equals("Q"))
                {
                if (int.TryParse(input, out number))
                {
                    if (number >= 0 && number <=10)
                    {
                        goodCounter++;
                    }else
                    {
                        badCounter++;
                    }
                }

                }

            } while (!input.ToUpper().Equals("Q"));
            Console.WriteLine("valid counter: {0}", goodCounter);
            Console.WriteLine("invalid counter: {0}", badCounter);
            Console.ReadKey();
        }
    }
}

            
            
            


