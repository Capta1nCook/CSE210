public class Video
{
    private string _title; // name of video
    private string _author; // name of video creator
    private int _length; // in seconds
    private List<Comment> _comments = new List<Comment>(); // List of comments

    public Video(string author, string title, int length) // constructor to call video class and save variables
    {
        _title = title;
        _author = author;
        _length = length;

        int i = 0;
        do
        {
        Comment comment = new Comment();
        _comments.Add(comment);
        i += 1;
        } while (i < 4);
    }

    public int CommentCount()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title}, {_author}, {_length}\n");
        Console.WriteLine($"   Comments: {CommentCount()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Display());
        }
    }
}