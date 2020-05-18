using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to do some stuff to: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of the operations is: " + MathOps.SomeMath(userNumber));

            Console.WriteLine("Enter a decimal to do some stuff: ");
            double userNumber2 = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("The result of the operation is: " + MathOps.SomeMath(userNumber2));

            Console.WriteLine("Please enter an integer to do some stuff to: ");
            string userNumber3 = Console.ReadLine();
            string failure = "";
            int result = MathOps.SomeMath(userNumber3, out failure);


            if (failure != "")
            {
                Console.WriteLine("The conversion to integer was impossible...");
            }
            else
            {
                Console.WriteLine("The result of the operation is: " + result);
            }

            Console.ReadLine();
        }
    }
}
