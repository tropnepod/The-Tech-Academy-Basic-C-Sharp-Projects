using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment2
{
    public class MathOps
    {
        public static double SomeMath(int userNumber)
        {
            return Math.Pow(userNumber, 5);
        }

        public static double SomeMath(double userNumber2)
        {
            int result = Convert.ToInt32(Math.Sqrt(userNumber2));
            return result;
        }

        public static int SomeMath(string userNumber3, out string failure)
        {
            bool isValid = Int32.TryParse(userNumber3, out int result);
            failure = "";
            if (isValid)
            {
                int number = Convert.ToInt32(userNumber3);
                int operation = Convert.ToInt32((number * 145) - Math.Pow(number, 2));
                return operation;
            }
            else
            {
                failure = "There is no spoon";
                return result;
            }
            
            
            

        }
    }
}
