using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = ("yes");
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int number = 9999;

            while (magicNumber != number)
            {
                Console.Write("What is the magic number? ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                if (magicNumber > number)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You Guessed it!!");
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}