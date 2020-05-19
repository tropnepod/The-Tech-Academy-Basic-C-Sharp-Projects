using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment5
{
    public static class DinoInt
    {
        

        public static void Mod1(int number, out int result)
        {
            result = number / 2;
            Console.WriteLine("The result is: " + result);
        }

        public static void Mod2(double number, out double mod2Result, out string mod2Msg)
        {
            mod2Result = (number * 325) + (number / 128);
            mod2Msg = "The result of the operation is: " + mod2Result.ToString();

        }
        
        public static void Mod2(string entry, out string newString)
        {
            
            char[] charEntry = entry.ToCharArray();

            Array.Reverse(charEntry);
            string tempString = new string(charEntry);
            newString = tempString.ToUpper();
            
        }
        
    }
}
