using System;
using System.Collections.Generic;


namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Hello", "I", "am", "an", "array", "of", "strings" };
            Console.WriteLine("Please select a number between 0 and 6:");
            int indexSelection = Convert.ToInt32(Console.ReadLine());
            if (indexSelection > 6 || indexSelection < 0) // make sure user can't select an index outside the array
            {
                Console.WriteLine("Please follow instructions...");
            }
            else
            {
                Console.WriteLine(strArray[indexSelection]);
            }

            int[] intArray = { 2, 10, 22, 13, 55, 107, 244, 48575 };
            Console.WriteLine("Please select a number to see an array value (0 - 7)");
            indexSelection = Convert.ToInt32(Console.ReadLine());
            if (indexSelection > 6 || indexSelection < 0) // make sure user can't select an index outside the array
            {
                Console.WriteLine("Please follow instructions...");
            }
            else
            {
                Console.WriteLine(intArray[indexSelection]);
            }

            List<string> strList = new List<string>(); 
            strList.Add("Doodle");
            strList.Add("This");
            strList.Add("is my");
            strList.Add("String List");
            strList.Add("I wonder");
            strList.Add("Which index");
            strList.Add("the UsEr");
            strList.Add("Will PICK!");
            Console.WriteLine("Please select an index to find out the list value (0 - 7):");
            indexSelection = Convert.ToInt32(Console.ReadLine());
            if (indexSelection > 7 || indexSelection < 0) // make sure user can't select an index outside the array
            {
                Console.WriteLine("Please follow instructions...");
            }
            else
            {
                Console.WriteLine(strList[indexSelection]);
            }
            Console.ReadLine();
        }
    }
}
