using System;
class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
    
        while (true)
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit\n");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                thejournal.AddEntry();
            }
            else if (option == 2)
            {
                thejournal.DisplayAll();
            }
            else if (option == 3)
            {
                thejournal.SaveToFile();
            }
            else if (option == 4)
            {
                thejournal.LoadFromFile();
            }
            else if (option == 5)
            {
                return;
            }
            
            
        }
    }
}