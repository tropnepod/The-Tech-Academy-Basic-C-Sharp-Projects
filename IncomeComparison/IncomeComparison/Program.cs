using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string person1Rate = Console.ReadLine();
            decimal p1Rate = Convert.ToDecimal(person1Rate);
            Console.WriteLine("Hours worked per week?");
            string person1Hours = Console.ReadLine();
            int p1Hours = Convert.ToInt32(person1Hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string person2Rate = Console.ReadLine();
            decimal p2Rate = Convert.ToDecimal(person2Rate);
            Console.WriteLine("Hours worked per week?");
            string person2Hours = Console.ReadLine();
            int p2Hours = Convert.ToInt32(person2Hours);

            decimal p1AnnualSalary = (p1Rate * p1Hours) * 52;
            decimal p2AnnualSalary = (p2Rate * p2Hours) * 52;

            Console.WriteLine("Annual salary of Person 1:\n" + p1AnnualSalary.ToString());
            Console.WriteLine("Annual salary of Person 2:\n" + p2AnnualSalary.ToString());

            bool p1GreaterIncome = p1AnnualSalary > p2AnnualSalary;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1GreaterIncome.ToString());
            Console.ReadLine();
        }
    }
}
