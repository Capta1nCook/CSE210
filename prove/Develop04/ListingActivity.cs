using System.Diagnostics;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some hobbies or activities that bring you joy?",
        "What is a skill you'd like to learn or improve on?",
        "What is a place you've always dreamed of visiting?",
        "What is a book or movie that has had a lasting impact on you?",
        "What is your favorite tradition or ritual?",
        "What brings you a sense of peace or calm?",
        "What is something you're grateful for today?",
        "What upcoming event are you most looking forward to?",
        "What is a challenge you're currently facing?",
        "What makes you laugh?",
        "What is your favorite food or meal?",
        "What is a cause you care deeply about?",
        "What is your ideal way to spend a day off?",
        "What is a piece of advice you would give to your younger self?",
        "What is something you're proud of accomplishing?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        GetListfromUser();

        Console.WriteLine($"You listed {_count} items!!");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count())];
        return prompt;
    }

    public List<string> GetListfromUser()
    {
        List<string> responses = new List<string>();
        string userInput;

        Stopwatch timer = new Stopwatch();
        timer.Start();

        do
        {
            Console.Write("> ");
            userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                responses.Add(userInput);
                _count += 1;
            }

            if (timer.ElapsedMilliseconds >= _duration * 1000)
            {
                break;
            }

        } while (userInput.ToLower() != "done");

        return responses;
    }
}

        