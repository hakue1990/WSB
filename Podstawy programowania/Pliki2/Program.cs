using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pliki
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\student");

            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Parent);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\student\c#Files"); // tworzy obiekt do sprawdza właściwości

            string[] customeres =
            {
                "Anna Kowalska",
                "PAweł Nowak",
                "Anna Kowal"
            };
            string path = @"C:\Users\student\C#Files";
            try
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(@"C:\Users\student\C#Files");
                    string textFilePath = @"C:\Users\student\C#Files\testFile1.txt";

                    File.WriteAllLines(textFilePath, customeres);

                }
                else
                {
                    Console.WriteLine("katalog został utworzony");
                    Console.WriteLine("Katalog został utworzony: {0}", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: {0}", e.Message);
                throw;
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@path); 



            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Ilość plików to: {0}",txtFiles.Length);

            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine();
                Console.WriteLine("nazwa: {0}",file.Name);
                Console.WriteLine("rozmiar: {0}",file.Length);
                Console.WriteLine();
            }


            if (Directory.Exists(path))

            {
                Console.WriteLine("Czy chcesz usunac katalog? (\n1 - TRUE\n0 - FALSE");
                string delete = Console.ReadLine();
                if (delete == "1")
                {
                    Directory.Delete(path, true); //true usuwa katalog z zawartością rekurencyjnie
                    if (!Directory.Exists(path))
                    {
                        Console.WriteLine("katalog zostal usuniety mordo");
                        Console.WriteLine("nazwa katalogu mordo, ktory usunoles to: {0}", Path.GetFileName(path));
                        Console.WriteLine(path);
                    }
                }
                else
                {
                    Console.WriteLine("nie usunołeś katalogu!");
                }
            }

            Console.ReadKey();
        }
    }
}
