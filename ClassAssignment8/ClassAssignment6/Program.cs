using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1};
            Employee example2 = new Employee() { FirstName = "John", LastName = "Doe", Id = 2 };
            Employee duplicate = new Employee();
            
            
            example.SayName();
            example2.SayName();
            duplicate = example==example2; // sets 'duplicate' value to example2 if it is a duplicate of example,
                                            //  other will return an empty Employee object
            if (duplicate.FirstName != null)
            {
                Console.WriteLine("Name: {0} {1}, ID: {2} is a duplicate employee number", duplicate.FirstName,duplicate.LastName, duplicate.Id);
            }
            
            Console.ReadLine();

            //IQuittable interfaceExample = new Employee();
            //interfaceExample.Quit();
        }
    }
}
