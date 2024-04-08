using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        bool start = true;
        while (start == true)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.Write("Menu Options: \n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    start = false;
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        int number = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetName()}");
            number += 1;
        }
    }
    public void ListGoalDetails()
    {
        int number = 1;
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDetailString()}");
            number += 1;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which Goal would you like? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your Goal: ");
        string name = Console.ReadLine();

        Console.Write("Give a description of your Goal: ");
        string description = Console.ReadLine();

        Console.Write("How many points is it worth: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many time must be completed for a bonus: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("How many points is the bonus worth: ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, 0);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("\nThe Goals are:");
        ListGoalNames();

        Console.Write("Which Goal did you accomplish: ");
        int choice = int.Parse(Console.ReadLine());

        _score += _goals[choice - 1].RecordEvent();
    }
    public void SaveGoals()
    {
        Console.Write("\nName your Goals: ");
        string fileName = Console.ReadLine() + ".txt";

        Console.Write("\nSaving to file...");
        Spinner();
        Console.WriteLine();
        

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            outputfile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("\nWhat Goals do you want to load: ");
        string loadfilename = Console.ReadLine() + ".txt";

        Console.Write("\nLoading from file...");
        Spinner();
        Console.WriteLine();

        string[] lines = File.ReadAllLines(loadfilename);

        int count = 0;
        foreach (string line in lines)
        {
            string[] info = line.Split(",");

            if (count == 0)
            {
                _score = int.Parse(info[0]);
            }

            else if (info[0] == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(info[1], info[2], int.Parse(info[3]), bool.Parse(info[4]));
                _goals.Add(simpleGoal);
            }
            else if (info[0] == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal(info[1], info[2], int.Parse(info[3]));
                _goals.Add(eternalGoal);
            }
            else if (info[0] == "Checklist Goal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(info[1], info[2], int.Parse(info[3]), int.Parse(info[5]), int.Parse(info[4]), int.Parse(info[6]));
                _goals.Add(checklistGoal);
            }
            count += 1;

        }
    }
    public void Spinner()
    {
        int count = 2;
        while (count != 0)
        {
            count -= 1;
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}