public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        Console.Clear();

        _name = name;
        _description = description;

        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
        Console.Write("How long, in seconds, do you you want this session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.Write("\nGet Ready...");
        ShowSpinner(2);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Write("\nWell Done!! ");
        ShowSpinner(2);
        Console.Clear();
    }

    public void ShowSpinner(int duration)
    {
        int count = duration;
        while (count != 0)
        {
            count -= 1;
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountdown(int duration)
    {
        for (int i = duration; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
            
    }
}