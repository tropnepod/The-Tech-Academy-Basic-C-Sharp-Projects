using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            TakeTwo example = new TakeTwo();
            example.Marbles(12, 137);
            example.Marbles(int2: 45, int1: 34);

            Console.ReadLine();
        }
    }
}
