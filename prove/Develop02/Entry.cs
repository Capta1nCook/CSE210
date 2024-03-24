public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        _date = theCurrentTime.ToShortDateString();
        _promptText = "";
        _entryText = Console.ReadLine();
    }
}