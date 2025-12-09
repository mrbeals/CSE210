using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

// Stretch: Added Leveling for the User.
class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        User user = new User();
        int choice = 0;
        
        while (choice < 6){
            choice = menu();
            if (choice == 1)
            {

                Console.WriteLine("\nThe Types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("What type of goal would you want to create? ");
                string goalstr = Console.ReadLine();
                int goalselect = int.Parse(goalstr);

                CreateGoal(goalselect);
            }
            else if (choice == 2)
            {
                user.Display();
                foreach (Goal goal in goals)
                {
                    goal.Display();
                }
            }
            else if (choice == 3) 
            {
                Console.Write("What is the Name of the File? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(user.UserString());
                        foreach (Goal goal in goals)
                            {
                                outputFile.WriteLine(goal.GoalString());
                            }
                    }
            }
            else if (choice == 4)
            {
                Console.Write("What is the Name of the File? ");
                string fileName = Console.ReadLine();


                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("||");

                    string type = parts[0];
                    if (type == "User")
                    {
                        string pointsStr = parts[1];
                        int points =  int.Parse(pointsStr);
                        string levelStr = parts[2];
                        int level = int.Parse(levelStr);
                        user.SetLevel(level);
                        user.SetPoints(points);
                    }
                    else if (type == "Goal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        string pointstr = parts[3];
                        int points = int.Parse(pointstr);
                        string completionStr = parts[4];
                        Boolean completed = false;
                        if (completionStr.ToLower() == "true")
                        {
                            completed = true;
                        }
                        else
                        {
                            completed = false;
                        }
                        Goal goal = new Goal(name, description, points, completed);
                        goals.Add(goal);
                    }
                    else if (type == "EternalGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        string pointstr = parts[3];
                        int points = int.Parse(pointstr);
                        string completionStr = parts[4];
                        Boolean completed = false;
                        if (completionStr.ToLower() == "true")
                        {
                            completed = true;
                        }
                        else
                        {
                            completed = false;
                        }
                        EternalGoal goal = new EternalGoal(name, description, points, completed);
                        goals.Add(goal);
                    }
                    else if (type == "CheckListGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        string pointstr = parts[3];
                        int points = int.Parse(pointstr);
                        string completionStr = parts[4];
                        Boolean completed = false;
                        if (completionStr.ToLower() == "true")
                        {
                            completed = true;
                        }
                        else
                        {
                            completed = false;
                        }
                        string completionTimesStr = parts[5];
                        int completionTimes = int.Parse(completionTimesStr);
                        string completionCounterStr = parts[6];
                        int completionCounter = int.Parse(completionCounterStr);
                        string bonusPointsStr = parts[7];
                        int bonusPoints = int.Parse(bonusPointsStr);
                        CheckListGoal goal = new CheckListGoal(name, description, points, completed, completionTimes, completionCounter, bonusPoints);
                        goals.Add(goal);
                    }
                    
                }
            }

            else if (choice == 5)
            {   
                int increment = 1;
                foreach (Goal goal in goals)
                {

                    Console.WriteLine($"{increment}. {goal.GetName()}");
                    increment += 1;
                }
                Console.Write("Which Goal has been completed? ");
                int completedGoal = int.Parse(Console.ReadLine());
                goals[completedGoal - 1].Complete();
                user.AddPoints(goals[completedGoal - 1].PointAward());
                user.LevelUp();
            }

            else if (choice == 6)
            {
                Console.WriteLine("Gosh, I hope you saved! ");
            }

        }
        int menu()
            {
                user.Display();   

                Console.WriteLine("Menu Options: ");
                Console.WriteLine(" 1. Create New Goal");     
                Console.WriteLine(" 2. List Goals");     
                Console.WriteLine(" 3. Save Goals");     
                Console.WriteLine(" 4. Load Goals");     
                Console.WriteLine(" 5. Record Event");          
                Console.WriteLine(" 6. Quit");     
                Console.Write("Select a choice from the menu: ");     
                string choicestr = Console.ReadLine();
                int choiceint = int.Parse(choicestr);
                return choiceint;
            }
        void CreateGoal(int choice)
        {
            if (choice == 1)
            {
                Console.Write("What is the name of goal? ");
                string name = Console.ReadLine();
                Console.Write("What is the description? ");
                string description = Console.ReadLine();
                Console.Write("How many points is it worth? ");
                string pointstr = Console.ReadLine();
                int points = int.Parse(pointstr);
                Goal goal = new Goal(name, description, points);
                goals.Add(goal);
            }
            else if (choice == 2) {
                Console.Write("What is the name of goal? ");
                string name = Console.ReadLine();
                Console.Write("What is the description? ");
                string description = Console.ReadLine();
                Console.Write("How many points is it worth? ");
                string pointstr = Console.ReadLine();
                int points = int.Parse(pointstr);
                EternalGoal goal = new EternalGoal(name, description, points);
                goals.Add(goal);
            }
            else if (choice == 3)
            {
                Console.Write("What is the name of goal? ");
                string name = Console.ReadLine();
                Console.Write("What is the description? ");
                string description = Console.ReadLine();
                Console.Write("How many points is it worth? ");
                string pointStr = Console.ReadLine();
                int points = int.Parse(pointStr);
                Console.Write("How many times must it be completed? ");
                string timesStr = Console.ReadLine();
                int completionTimes = int.Parse(timesStr);
                Console.Write("How many bonus points is it worth? ");
                string bonusStr = Console.ReadLine();
                int bonusPoints = int.Parse(bonusStr);
                CheckListGoal goal = new CheckListGoal(name, description, points, completionTimes, bonusPoints);
                goals.Add(goal);
            }
        }


    }


}