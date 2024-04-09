public class OutdoorGathering : Event
{
    private bool _weather;

    public OutdoorGathering(string title, string description, string date, string time, string address, bool weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void CheckWeather()
    {
        if (_weather == true)
        {
            Console.WriteLine("Forcast says Good Weather");
        }
        else
        {
            Console.WriteLine("Forcast says poor weather, Recommend Reschedual or move Venue.");
        }
    }
}