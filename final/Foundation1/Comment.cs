public class Comment
{
    private string _name;
    private string _comment;

    public Comment()
    {
        CommentGenerator commentGenerator = new CommentGenerator();
        _name = commentGenerator.GetRandomName();
        _comment = commentGenerator.GetRandomComment();
    }

    public string Display()
    {
        return $"   {_name}: {_comment}";
    }
}