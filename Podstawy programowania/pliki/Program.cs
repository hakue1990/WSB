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

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\student\c#Files"); //

            string[] customeres =
            {
                "Anna Kowalska",
                "PAweł Nowak",
                "Anna Kowal"
            };

            string path = @"C:\Users\student\C#Files";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(@"C:\Users\student\C#Files");
                string textFilePath = @"C:\Users\student\C#Files\testFile1.txt";

                File.WriteAllLines(textFilePath, customeres);

            }
            else
            {
                Console.WriteLine("katalog został utworzony");
            }

            Console.ReadKey();
        }
    }
}
