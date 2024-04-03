public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        int count = _duration / (5 * 2);
        while (count >= 1)
        {
                Console.Write($"\nBreath in..."); 
                ShowCountdown(5);

                Console.Write($"Breath out..."); 
                ShowCountdown(5);
                count -= 1;
        }
    }
}