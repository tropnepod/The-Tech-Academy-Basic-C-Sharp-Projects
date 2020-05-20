using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number userNumber = new Number(); // instantiate 
            Number userNumber2 = userNumber; 
            userNumber.Amount = 13.8886468m; // set amount for userNumber
            Console.WriteLine(userNumber.Amount); // print value of userNumber.Amount
            Console.WriteLine(userNumber2.Amount); // print value of userNumber2.Amount to show setting one doesn't
            Console.ReadLine();                     // affect the other.
        }
    }
}
