public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {   
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you learned something new from a mistake.",
        "Think of a time when you surprised yourself with your capabilities.",
        "Think of a time when you had to make a tough decision.",
        "Think of a time when you stood up for what you believed in, even when it wasn't popular.",
        "Think of a time when you showed creativity to solve a problem.",
        "Think of a time when you worked hard and achieved a goal.",
        "Think of a time when you learned to appreciate something you previously took for granted.",
        "Think of a time when you connected with someone from a different background.",
        "Think of a time when you witnessed an act of kindness and it inspired you."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "Who else was involved in this experience, and how did it impact them?",
        "Did you face any challenges or obstacles along the way? How did you overcome them?",
        "Looking back, would you have done anything differently?",
        "What advice would you give to someone facing a similar situation?",
        "Did this experience change your perspective on anything?",
        "How did this experience connect to your values or beliefs?",
        "Was there a specific moment during this experience that stands out the most?",
        "How has this experience impacted the way you approach similar situations now?",
        "Would you be willing to share this experience with others? Why or why not?",
        "What emotions did you experience throughout this journey, and how did they change?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:\n");
        Console.Write($"--- {prompt} ---\n\n");
        Console.Write("Press Enter when ready:");
        Console.ReadLine();
        Console.Clear();
        Console.Write("\nAnswer the following questions as they relate to the experience: "); 
        ShowSpinner(2);
        Console.WriteLine("");

        int count = _duration / (5 * 2);
        while (count >= 1)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} "); 
            ShowSpinner(5);
            count -= 1;
        }
        Console.WriteLine("");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count())];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count())];
        return question;
    }
}