using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment6
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            // Console.WriteLine("This is coming from the Employee Class...");
            base.SayName();
        }
        public int Id { get; set; }
        
        
        
        public void Quit()
        {
            Console.WriteLine("Press enter to close the application: ");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static Employee operator ==(Employee example, Employee example2)
        {
            if (example.Id == example2.Id)
            {               
                Console.WriteLine("These have matching ID numbers!");
                return example2; // returns the duplicated entry, that can be removed
            }
            else
            {
                Console.WriteLine("These are NOT duplicate entries...");
                return new Employee(); // will return empty object if not a duplicate
            }
            
        }

        public static Employee operator !=(Employee example, Employee example2)
        {
            if (example.Id == example2.Id)
            {
                Console.WriteLine("These have matching ID numbers!");
                return example2; // returns duplicated entry
            }
            else if (example.Id != example2.Id)
            {
                Console.WriteLine("ID numbers do not match...");
            }
            return new Employee(); // will return empty object if not a duplicate
        }
    }
}
