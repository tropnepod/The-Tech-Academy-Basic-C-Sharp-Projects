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
            Employee<string> example = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 1, things = new List<string>() { "thing 1", "thing 2", "thing 3", "thing 4", "thing 5" } };
            Employee<string> example2 = new Employee<string>() { FirstName = "John", LastName = "Doe", Id = 2 };
            Employee<string> duplicate = new Employee<string>();
            Employee<int> example3 = new Employee<int>() { things = new List<int>() { 1, 24, 53235, 235, 214, 643 } };
                        
            foreach (string thing in example.things)
            {
                Console.WriteLine("String list: " + thing.ToString());
            }
            foreach (int number in example3.things)
            {
                Console.WriteLine("Integer List: " + number.ToString());
            }            

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
