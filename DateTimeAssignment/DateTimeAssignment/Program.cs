using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentDateTime);
            Console.WriteLine("Please enter a number...");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In {0} hours, it will be {1}", number, currentDateTime.AddHours(number));
            
            Console.Read();
        }
    }
}
