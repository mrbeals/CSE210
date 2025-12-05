using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _listingPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    public ListingActivity(string name, int duration) : base(name,
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    duration)
    {
        _listingPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    public ListingActivity(int duration) : base("Listing Activity", 
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    duration)
    {
        _listingPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    public ListingActivity(string name, string description) : base(name, description, 60)
    {
        _listingPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    public ListingActivity() : base("Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    60)
    {
        _listingPrompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    private void ListItems(DateTime endTime)
    {
        Console.Clear();
        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            counter += 1;
        }
        Console.WriteLine($"You listed {counter} items!");
    }
    private string GetPrompt()
    {
        Random randomness = new Random();
        int length = _listingPrompts.Count();
        int randomIndex = randomness.Next(0, length);

        return _listingPrompts[randomIndex];
    }

    public void ListingExercise()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready...");
        SpinnerPause(5);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"-- {GetPrompt()} --");
        Console.Write("you may begin in: ");
        CountdownTimer(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        ListItems(endTime);
        DisplayEndingMessage();
    }
}