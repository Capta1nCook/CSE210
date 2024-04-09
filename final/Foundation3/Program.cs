using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();
        
        Lecture lecture = new Lecture("How to be Acting President", "Listeners will enjoy a 6 hour presentaion on how one man went from Actor to Presedent", "July, 5th, 2065", "6:30 AM", "810 S Hennepin Ave, Dixon, IL 61021", "Ronald Reagan", 15);
        _events.Add(lecture);
        lecture.GetEventInfo();
        lecture.Display();

        Reception reception = new Reception("Cook Wedding", "Marriage of Jared Cook and Rose Unferdorfer", "March, 20th, 2020", "5:00 PM", "41800 NW Covey Ln, Banks, OR 97106");
        _events.Add(reception);
        reception.AddRSVP("Roger Cook");
        reception.AddRSVP("Katie Cook");
        reception.AddRSVP("Jeffrey Edwards");
        reception.AddRSVP("Chris Jordan");
        reception.AddRSVP("Anna Ramburg");
        reception.GetEventInfo();
        reception.Display();

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Family Reunion", "Dale and Vesta Cook Family Reunion", "July 20th 2024", "2:00", "3883 E 97th N, Idaho Falls, ID 83401", true);
        _events.Add(outdoorGathering1);
        outdoorGathering1.GetEventInfo();
        outdoorGathering1.CheckWeather();

        OutdoorGathering outdoorGathering2 = new OutdoorGathering("Family Reunion", "Melvin and Betty Ott Family Reunion", "June 22th 2024", "6:00", "615 S Clark St, Butte, MT 59701", false);
        _events.Add(outdoorGathering2);
        outdoorGathering2.GetEventInfo();
        outdoorGathering2.CheckWeather();
    }
}