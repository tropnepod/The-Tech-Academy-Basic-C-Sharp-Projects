using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter your package weight (nearest whole number):");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width (nearest whole number):");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height (nearest whole number):");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length (nearest whole number):");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int dimensionTotal = packageWidth + packageHeight + packageLength;
                if (dimensionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal shippingQuote = (dimensionTotal * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + shippingQuote.ToString("C", CultureInfo.CurrentCulture));
                    Console.WriteLine("Thank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
