using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment6
{
    public class Employee : Person
    {
        public override void SayName()
        {
            // Console.WriteLine("This is coming from the Employee Class...");
            base.SayName();
        }
        public int Id { get; set; }
    }
}
