public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public BreathingActivity(string name, int duration) : base(name,
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    duration)
    {
    }
    public BreathingActivity(int duration) : base("Breathing Activity", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    duration)
    {
    }
    public BreathingActivity(string name, string description) : base(name, description, 60)
    {
    }
    public BreathingActivity() : base("Breathing Activity",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    60)
    {
    }
    private void BreatheIn(int time)
    {
        Console.Write("\nBreathe in...");
        CountdownTimer(time);
    }
    private void BreatheOut(int time)
    {
        Console.Write("\nNow breathe out...");
        CountdownTimer(time);
        Console.WriteLine("");
    }
    private void Breathing(DateTime endTime)
    {
        while (DateTime.Now < endTime)
        {
            if (endTime - DateTime.Now < TimeSpan.FromSeconds(10))
            {
                int secondsRemaining = (int)Math.Round((endTime - DateTime.Now).TotalSeconds);

                if (secondsRemaining > 4)
                {
                    BreatheIn(4);
                    secondsRemaining -= 4;
                    BreatheOut(secondsRemaining);
                }
                else
                {
                    BreatheIn(secondsRemaining);
                }
            }
            else
            {
                BreatheIn(4);
                BreatheOut(6);
            }
        }
    }
    

    public void BreathingExercise()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready...");
        SpinnerPause(5);
        Console.Write("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Breathing(endTime);
        DisplayEndingMessage();
    }
}