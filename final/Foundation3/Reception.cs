public class Reception : Event
{
    private List<string> _rsvp = new List<string>();

    public Reception(string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {

    }

    public void AddRSVP(string name)
    {
        _rsvp.Add(name);
    }
    public void Display()
    {
        Console.WriteLine("RSVP list:");
        int lineCount = 0;
        foreach (string rsvp in _rsvp)
        {
            if (lineCount == 3)
            {
                lineCount = 0;
                Console.Write("\n");
            }
            else
            {
                lineCount += 1;
            }
            Console.Write($"{rsvp} ");
        }
        Console.WriteLine();
    }
}