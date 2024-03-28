public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry anentry = new Entry();
        anentry._promptText =  promptGenerator.GetRandomPrompt();
        Console.WriteLine(anentry._promptText);
        anentry._entryText = Console.ReadLine();

        _entries.Add(anentry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("********End********\n");
        
    }

    public void SaveToFile()
    {
        Console.WriteLine("\nName your Journal: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Saving to file...\n");

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        _entries.Clear();
        Console.WriteLine("\nWhat Journal do you want to load? ");
        string loadfilename = Console.ReadLine() + ".txt";

        Console.WriteLine("Loading from file...\n");

        string[] lines = File.ReadAllLines(loadfilename);
        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            string[] info = line.Split("~~");

            Entry anentry = new Entry();
            anentry._date = info[0];
            anentry._promptText = info[1];
            anentry._entryText = info[2];

            _entries.Add(anentry);
        }
    }
}