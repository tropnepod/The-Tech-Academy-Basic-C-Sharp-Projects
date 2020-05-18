using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class MathStuff
    {
        public static int TripleDouble(int userNumber)
        {
            return ((3 * userNumber) * 2);
        }

        public static int SecretMath(int userNumber)
        {
            return (((userNumber + 167) * 23) - 67);
        }

        public static int ThirdPower(int userNumber)
        {
            return (userNumber ^ 3);
        }
    }
}
