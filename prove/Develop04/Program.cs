using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopBreak = true;
        while (loopBreak == true)
        {
            Console.WriteLine("Menu Options: \n 1. Start Breathing Activity\n 2. Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();

                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();

                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();

                    break;

                case 4:
                    Console.Clear();
                    loopBreak = false;

                    break;

                default:
                    Console.WriteLine("Not a valid input...");

                    break;
            }
        }
    }
}