using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string numEntered = Console.ReadLine();
            double number = Convert.ToDouble(numEntered);
            double result = number * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + result.ToString());
            Console.WriteLine("Please enter a number: ");
            string secondNumber = Console.ReadLine();
            double result2 = Convert.ToDouble(secondNumber) + 25;
            Console.WriteLine("Your number plus 25 = " + result2.ToString());
            Console.WriteLine("Please enter a number: ");
            string thirdNumber = Console.ReadLine();
            double result3 = Convert.ToDouble(thirdNumber) / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + result3);
            Console.WriteLine("Please enter a number: ");
            string fourthNumber = Console.ReadLine();
            bool result4 = Convert.ToDouble(fourthNumber) > 50;
            Console.WriteLine("Is the number greater than 50: " + result4.ToString());
            Console.WriteLine("Please enter a number: ");
            string fifthNumber = Console.ReadLine();
            double remainder = Convert.ToDouble(fifthNumber) % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + remainder.ToString());


            Console.ReadLine();
        }
    }
}
