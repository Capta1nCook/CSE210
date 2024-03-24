using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Entry anEntry = new Entry();
            }
            else if (option == 2)
            {
                anEntry.Display();
            }
            else if (option == 3)
            {

            }
            else if (option == 4)
            {

            }
            else if (option == 5)
            {
                return;
            }

            Journal thejournal = new Journal();
            
            Console.WriteLine("Hello Develop02 World!");
        }
    }
}