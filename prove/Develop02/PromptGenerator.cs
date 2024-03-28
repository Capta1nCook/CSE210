using System;
public class PromptGenerator
{
    private string[] _prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What surprised me the most today?",
            "What did I learn today that I can apply tomorrow?",
            "What am I grateful for today (big or small)?",
            "What challenge did I overcome today? How did I do it?",
            "What act of kindness did I witness or perform today?",
            "What made me laugh today?",
            "Is there something I've been putting off that I should prioritize tomorrow?",
            "Who or what inspired me today?",
            "What did I accomplish today that made me feel proud?",
            "If I could give myself one piece of advice for tomorrow, what would it be?"
        };

    public PromptGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count());
        return _prompts[randomIndex];
    }
}