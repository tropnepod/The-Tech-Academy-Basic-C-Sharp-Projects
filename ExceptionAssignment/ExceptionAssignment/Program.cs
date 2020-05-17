using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 2, 3, 7, 12, 15, 20, 100, 150, 175 };
            Console.WriteLine("Please enter a whole number to divide each number in the list by: ");
            
            try
            {
                int dividingNum = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numList)
                {
                    double result = Convert.ToDouble(num) / Convert.ToDouble(dividingNum);
                    Console.WriteLine(num + " divided by " + dividingNum + " equals " + result);
                }
            }
            catch (FormatException X)
            {
                Console.WriteLine("You need to enter a whole number...");
            }
            catch (DivideByZeroException X)
            {
                Console.WriteLine("You can't divide by zero...");
            }
            catch (Exception X)
            {
                Console.WriteLine(X.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("This line is outside the try/catch block...");
            Console.ReadLine();
        }
    }
}
