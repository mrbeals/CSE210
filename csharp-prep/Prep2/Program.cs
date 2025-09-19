using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string percString = Console.ReadLine();
        int percent = int.Parse(percString);

        string grade = "N/A";
        bool pass = false;
        if (percent >= 90)
        {
            grade = "A";
            pass = true;
        }
        else if (percent >= 80)
        {
            grade = "B";
            pass = true;
        }
        else if (percent >= 70)
        {
            grade = "C";
            pass = true;
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (percent >= 60 && percent < 93)
        {
            if (percent % 10 < 3)
            {
                grade += "-";
            }
            else if (percent % 10 >= 7)
            {
                grade += "+";
            }
        }
        Console.WriteLine($"You have received a {grade} in this class.");
        if (pass == true)
        {
            Console.WriteLine($"You passed!");
        }
        else
        {
            Console.WriteLine($"You Failed!");
        }
    }
}