using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number to do some math operations on: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Op 1: " + MathStuff.TripleDouble(userNumber));
            Console.WriteLine("Op 2: " + MathStuff.SecretMath(userNumber));
            Console.WriteLine("Op 3: " + MathStuff.ThirdPower(userNumber));

            Console.ReadLine();

        }
    }
}
