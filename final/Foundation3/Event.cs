public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void GetEventInfo()
    {
        Console.WriteLine($"\n---{_title}---\n{_description}\n{_date} {_time}\n{_address}");
    }
}