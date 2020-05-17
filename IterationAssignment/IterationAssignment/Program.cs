using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string[] strArray = new string[5] { "Mad Libs: ","I: ","Am: ","Inputing: ","String Values: "}; // create array with 5 values
        Console.WriteLine("Input some text: ");
        string textAddition = Console.ReadLine();

        for (int i = 0; i < strArray.Length; i++) // loop to fill array with user input
        {
            strArray[i] = strArray[i] + textAddition;
        }
        for (int i = 0; i < strArray.Length; i++) // loop to print each value of the array
        {
            Console.WriteLine(strArray[i]);
        }

        for (int i = 0; i < 1; i++) //infinite loop
        {
            Console.WriteLine("Welcome to Infinity!");
            // i--;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Loop 2: " + i);
        }

        List<string> uniqueItems = new List<string>() { "magenta", "turtle", "indigo", "matrix", "betty" };
        Console.WriteLine("Enter a word to see if it's in the list: ");
        string userText = Console.ReadLine();
        
        
        for (int i = 0; i < uniqueItems.Count; i++)
        {
            if (uniqueItems[i] == userText)
            {
                Console.WriteLine("The index of the matching word is: " + i);
                break;
            }
            if (uniqueItems.Contains(userText) == false)
            {
                Console.WriteLine("Your input is not in the list.");
                break;
            }

        }

        List<string> strList = new List<string>() { "peanutbutter", "stalker", "abominable", "kitten", "balloon", "galaxy", "glasses", "turkey", "stalker" };
        Console.WriteLine("Enter word to see if it's in the list: ");
        string userInput = Console.ReadLine();
        for (int i = 0; i < strList.Count; i++)
        {
            if (userInput == strList[i])
            {
                Console.WriteLine("The text entered matches the index: " + i);
            }
            if (strList.Contains(userInput) == false)
            {
                Console.WriteLine("Your input is not in the list.");
                break;
            }
        }

        List<string> strList2 = new List<string>() { "magic","penguins","valley","horror","ducks","trees","blue","nothing","horror","last"};
        List<string> items = new List<string>();
        foreach (string item in strList2)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
                Console.WriteLine(item + " has not yet appeared in the list.");
            }
            else if (items.Contains(item))
            {
                Console.WriteLine(item + " has already appeared in the list!");
            }

        }

        Console.ReadLine();
    }
}
