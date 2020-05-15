using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the magic number?");
            int number = Convert.ToInt32(Console.ReadLine());
            int magicNumber = 13;

            bool isCorrect = false;

            do
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("Nope, it's not 10!");
                        Console.WriteLine("What is the magic number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("Nope, it's not 20!");
                        Console.WriteLine("What is the magic number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("Nope, it's not 50. keep guessing....");
                        Console.WriteLine("What is the magic number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("YOU GUESSED IT! 13 is the magic number!");
                        isCorrect = true;
                        break;
                    default:
                        Console.WriteLine("Wrong again!");
                        Console.WriteLine("What is the magic number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!isCorrect);

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            while (isCorrect) // this while will always have an initial run because the isCorrect value will always be true to end the previous loop
            {
                switch (animal)
                {
                    case "dog":
                        Console.WriteLine("THAT'S THE BEST ANIMAL!");
                        isCorrect = false;
                        break;
                    case "cat":
                        Console.WriteLine("Cats are great, but that's not what we're looking for.");
                        Console.WriteLine("Enter an animal: ");
                        animal = Console.ReadLine();
                        break;
                    case "bird":
                        Console.WriteLine("Birds are cool, but that's still not it.");
                        Console.WriteLine("Enter an animal: ");
                        animal = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Find me an animal I like better than the others!");
                        Console.WriteLine("Enter an animal: ");
                        animal = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
