using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment3
{
    class TakeTwo
    {
        public static int Smash(int userNumber1, int optionalNum = 0)
        {
            int op1 = Convert.ToInt32((Math.Pow(userNumber1, 2)) - userNumber1);
            int op2 = Convert.ToInt32((Math.Pow(optionalNum, 2)) - optionalNum);
            int result = op1 + op2;
            return result;
            
        }
    }
}
