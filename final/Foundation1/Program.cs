using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Denver Conger", "How to raise a Family", 549);
        videos.Add(video1);

        Video video2 = new Video("Ian Miller", "Gaming at Work", 426);
        videos.Add(video2);

        Video video3 = new Video("Ethan Shirly", "Thoughts on Marriage and Family", 1026);
        videos.Add(video3);

        Video video4 = new Video("Colby Smith", "How to ignore Phone Calls", 206);
        videos.Add(video4);

        foreach (Video video in videos)
            video.Display();
    }
}