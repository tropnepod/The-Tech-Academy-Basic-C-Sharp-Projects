using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter a number to be divided by two: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result;
            DinoInt.Mod1(number, out result);

            Console.WriteLine("Please enter a numeric value: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            double mod2Result;
            string mod2Msg;
            DinoInt.Mod2(userInput, out mod2Result, out mod2Msg);
            Console.WriteLine(mod2Msg);

            Console.WriteLine("Enter a word or sentence: ");
            string userInput2 = Console.ReadLine();
            string newString;
            DinoInt.Mod2(userInput2, out newString);
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
