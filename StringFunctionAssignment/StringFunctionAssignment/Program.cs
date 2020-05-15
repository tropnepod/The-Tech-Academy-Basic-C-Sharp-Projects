using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Bob";
            string name2 = "Joe";
            string name3 = "Moe";
            string group = "The three people in the group are " + name1 + ", " + name2 + ", and " + name3 + ".";
            Console.WriteLine(group);
            Console.WriteLine(name3.ToUpper());

            string sent1 = "This is the first sentence of the paragraph. ";
            string sent2 = "This is the second sentence of the paragraph. ";
            string sent3 = "This is the third sentence of the paragraph. ";
            string sent4 = "This is the fourth sentence of the paragraph. ";
            string sent5 = "This is the fifth sentence of the paragraph. ";

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}{2}{3}{4}", sent1,sent2,sent3,sent4,sent5);
            sb.Insert(0, "\t");
            Console.WriteLine("Add the last sentence of the paragraph:");
            string lastSent = Console.ReadLine();
            sb.Append(lastSent);
            

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
