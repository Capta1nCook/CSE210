using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        
        while (true)
        {
            string choice = "";

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:\n");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                break;
            }
            else
            {

                scripture.HideRandomWords(3);
            }
        }
    }
}