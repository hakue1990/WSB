using System;


namespace inicjalizacji
{
    class Program
    {
        static void Main(string[] args)
        {
            // uproszczone wyrazenia inicjalizacji

            //char[] vowels = { 'a', 'e', 'i' };
            //Console.WriteLine(vowels[2]);

            //int[,] age =
            //    {
            // {10,20},
            // {30,40},
            // {50,60}
            //};
            //Console.WriteLine(age[1,1]);

            //string[][] name =
            //{
            //    new string[] {"Anna"},
            //    new string[] {"Anna","Nowak"},
            //    new string[] {"Anna"},
            //};


            //Console.WriteLine(name[1][1]);
            //Console.WriteLine("ilosc wymiarów {0}", name.Rank);
            //Console.WriteLine("ilosc wymiarów {0}", age.Rank);
            //Console.WriteLine("ilosc wymiarów {0}", vowels.Rank);

            ////kopiowanie tablic

            //int[] tab = { 1, 2, 3, 4, 5,6,7,8 };

            //int[] tabCopy = new int[8];

            //foreach (int item in tabCopy)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            ////tab.CopyTo(tabCopy, 0);


            //for (int i = 0; i < tabCopy.Length; i++)
            //{
            //    Console.WriteLine(tabCopy[i]);
            //}

            //Array.Copy(tab, tabCopy, tab.Length);

            //for (int i = 0; i < tabCopy.Length; i++)
            //{
            //    Console.WriteLine(tabCopy[i]);
            //}

            //MODYFIKATORY KONSOLI

            //Console.Title = "modyfikacja konsoli";
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("wsb");
            ////Console.Clear();
            //Console.ResetColor();
            //Console.WriteLine("siema");

            //TYPY WARTOŚCIOWE I REFERENCYJNE

            // typ wartościowy

            //int a = 10;
            //int b = a;

            //a--;
            //b++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //typy referencyjne

            //int[] tabA = { 1, 2, 3 };
            //int[] tabB = tabA;

            //tabA[1] = 100;
            //tabB[tabB.Length - 1] = 200;
            //Console.WriteLine("tabA");
            //foreach (int item in tabA)
            //{
            //    Console.WriteLine("{0}", item);

            //}
            //Console.WriteLine("tabB");
            //foreach (int item in tabB)
            //{
            //    Console.WriteLine("{0}", item);

            //}

            //int[] tab3 = { 1, 2, 3 };
            //int[] tab4 = new int[3];

            //tab3.CopyTo(tab4, 0);

            //Console.WriteLine("tab3");
            //foreach (int item in tab4)
            //{
            //    Console.WriteLine("{0}", item);

            //}


            // przypisanie tablicy do drugiej tworzy referencje a kopiowanie tablicyzastepuje nam istniejaca

            //*************************************************************************************************************************************************************

            // WYJĄTKI 1
           string x;
            uint number;
            while (true)
            {
                Console.WriteLine("wprowadz liczbe całkowitą!");
              
                try
                {

             x = Console.ReadLine();
             number = uint.Parse(x);
                    break;

                }
                catch (SystemException e)
                {
                    Console.WriteLine("error {0}", e.Message);
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("prawidlowe dane: {0}", number);

            Console.ReadKey();
        }
    }
}
