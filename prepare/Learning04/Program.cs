using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jared Cook", "Object-Oriented Programming");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Ricky Vang", "Fractions", "5.2", "1-17");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Jase Dryden", "Civil War", "Civil War History 101 By John Wilkes Booth");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingAssignment());
    }
}