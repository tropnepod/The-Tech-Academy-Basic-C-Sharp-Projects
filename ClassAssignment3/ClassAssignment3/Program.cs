using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int optionalNum;
            Console.WriteLine("Please enter an integer: ");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may now enter another integer or nothing: ");
            string userNumber2 = Console.ReadLine();
            if (userNumber2 != "")
            {
                try
                {
                    optionalNum = Convert.ToInt32(userNumber2);
                    Console.WriteLine("The results are: " + TakeTwo.Smash(userNumber1, optionalNum));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your did not enter an integer...");
                }
                
            }
            else
            {
                Console.WriteLine("The results are: " + TakeTwo.Smash(userNumber1));
            }
            

            Console.ReadLine();
        }
    }
}
