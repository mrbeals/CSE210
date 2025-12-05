using System.Runtime.CompilerServices;

public class Activity
{
    protected string _activityName = "";
    protected string _description = "";
    protected int _duration = 0;


    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }
    public Activity(string name, int duration)
    {
        _activityName = name;
        _description = "No Description found";
        _duration = duration;
    }
    public Activity(int duration)
    {
        _activityName = "Nameless";
        _description = "No description found";
        _duration = duration;
    }
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
        _duration = 60;
    }
    public Activity()
    {
        _activityName = "Nameless";
        _description = "Description not found";
        _duration = 60;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void GetDuration()
    {
        string strDuration = Console.ReadLine();
        int duration = int.Parse(strDuration);
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string strDuration = Console.ReadLine();
        _duration = int.Parse(strDuration);
        Console.Clear();


    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void DisplayEndingMessage()
    {
        Console.Write("\nWell Done!!");
        SpinnerPause(3);
        Console.WriteLine("");
        Console.Write($"\nYou have completed another {_duration} seconds of {_activityName}.");
        SpinnerPause(5);
    }
    public void SpinnerPause(int time)
    {
        double doubletime = time;
        while (doubletime > 0) {
            Console.Write("/");
            Thread.Sleep(500);
            doubletime -= .5;
            Console.Write("\b \b");

            if (doubletime > 0){
                Console.Write("-");
                Thread.Sleep(500);
                doubletime -= .5;
                Console.Write("\b \b");

                if (doubletime > 0 ) {
                    Console.Write("\\");
                    Thread.Sleep(500);
                    doubletime -= .5;
                    Console.Write("\b \b");

                    if (doubletime > 0) {
                        Console.Write("|");
                        Thread.Sleep(500);
                        doubletime -= .5;
                        Console.Write("\b \b");
                    }
        }
        }
    }
    }
    public void CountdownTimer(int countdown)
    {
        
        while (countdown > 0)
        {
            Console.Write(countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdown -= 1;

        }
    }
    public void Display(string displayed)
    {
        Console.Write($"{displayed}");
    }
}