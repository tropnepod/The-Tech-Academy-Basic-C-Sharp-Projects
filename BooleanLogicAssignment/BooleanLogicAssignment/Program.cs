using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance");
            Console.WriteLine("What is your age?");
            string ageEntered = Console.ReadLine();
            int age = Convert.ToInt32(ageEntered);
            Console.WriteLine("Have you ever had a DUI? (yes/no)");
            string haveDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string numSpeedingTickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(numSpeedingTickets);
            bool qualified = ((age > 15) && (haveDUI == "no") && (numTickets <= 3));
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
