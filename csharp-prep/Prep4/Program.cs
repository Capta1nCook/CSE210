using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        
        
        int max = 0;

        foreach (int num in numbers)
        {
            total += num;
            if (num > max)
            {
                max = num;
            }
        }

        float average = total/numbers.Count;
        Console.WriteLine($" The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}