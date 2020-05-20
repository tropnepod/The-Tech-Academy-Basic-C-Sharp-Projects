using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>()
            {
                new Employee() { FirstName = "Lucy", LastName = "Student", Id = 1 },
                new Employee() { FirstName = "Joe", LastName = "Doe", Id = 2 },
                new Employee() { FirstName = "Bob", LastName = "Slydell", Id = 10 },
                new Employee() { FirstName = "Joe", LastName = "Duddy", Id = 3 },
                new Employee() { FirstName = "Abe", LastName = "Maisel", Id = 4 },
                new Employee() { FirstName = "Dorian", LastName = "Gray", Id = 5 },
                new Employee() { FirstName = "Uma", LastName = "Thurman", Id = 6 },
                new Employee() { FirstName = "Lucy", LastName = "Liu", Id = 7 },
                new Employee() { FirstName = "Chris", LastName = "Squares", Id = 8 },
                new Employee() { FirstName = "Keanu", LastName = "Reeves", Id = 9 },
            };
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in listOfEmployees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }
            Console.WriteLine("First Name\t"+"Last Name\t"+"ID Number");
            foreach (Employee employee in newList)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", employee.FirstName, employee.LastName, employee.Id);
            }

            List<Employee> newList2 = listOfEmployees.Where(x => x.FirstName == "Lucy").ToList();
            Console.WriteLine("Lambda List:");
            Console.WriteLine("First Name\t" + "Last Name\t" + "ID Number");

            foreach (Employee employee in newList2)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", employee.FirstName, employee.LastName, employee.Id);
            }

            List<Employee> idGreaterThan5 = listOfEmployees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Lambda List 2:");
            Console.WriteLine("First Name\t" + "Last Name\t" + "ID Number");

            foreach (Employee employee in idGreaterThan5)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();
        }
    }
}
