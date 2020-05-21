using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();
            string path = @"C:\Users\mrask\Desktop\Basic_Csharp_Projects\FileIOAssignment\FileIOAssignment\Logs\logs.txt";
            using (StreamWriter logNumber = File.AppendText(path))
            {
                logNumber.WriteLine(number);
            }
            Console.WriteLine("\n\n");
            using (StreamReader readFile = File.OpenText(path))
            {
                string s = "";
                int counter = 1;
                Console.WriteLine("The following is inside the text file: ");
                while ((s = readFile.ReadLine()) != null)
                {
                    Console.WriteLine("Number {0} is: {1}", counter, s);
                    counter++;
                }
            }

            Console.ReadLine();
        }
    }
}
