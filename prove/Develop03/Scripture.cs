using System.Text;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split())
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > _words.Count)
        {
            numberToHide = _words.Count;
        }
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(_reference.GetDisplayText());
        sb.AppendLine();

        foreach (Word word in _words)
        {
            sb.Append(word.GetDisplayText() + " ");
        }

        return sb.ToString().TrimEnd();
    }
}