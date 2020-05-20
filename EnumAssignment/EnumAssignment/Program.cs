using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Please enter the current day of the week (1-7): ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput > 0 && userInput < 8)
                {
                    WeekDay currentDay = (WeekDay)userInput;
                    Console.WriteLine(currentDay);
                }
                else
                {
                    Console.WriteLine("Please enter a valid day of the week...");
                }
                               
            }
            catch (FormatException X)
            {
                Console.WriteLine("Please enter a valid day of the week...");
            }
            catch (ArgumentException X)
            {
                Console.WriteLine(X.Message);
            }
            Console.ReadLine();
        }
    }
    public class Day
    {
        public WeekDay WeekDay { get; set; }
    }
    public enum WeekDay
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
}
