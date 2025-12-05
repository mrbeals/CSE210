using System.Reflection;

public class ReflectingActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _reflectionPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _reflectionQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }
    public ReflectingActivity(string name, int duration) : base(name,
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    duration)
    {
        _reflectionPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _reflectionQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }
    public ReflectingActivity(int duration) : base("Reflecting Activity", 
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    duration)
    {
        _reflectionPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _reflectionQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }
    public ReflectingActivity(string name, string description) : base(name, description, 60)
    {
        _reflectionPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _reflectionQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }
    public ReflectingActivity() : base("Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    60)
    {
        _reflectionPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _reflectionQuestions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    private string GetRandomQuesiton()
    {
        Random randomness = new Random();
        int length = _reflectionQuestions.Count();
        int randomIndex = randomness.Next(0, length);

        return _reflectionQuestions[randomIndex];
    }

    private string GetRandomPrompt()
    {
        Random randomness = new Random();
        int length = _reflectionPrompts.Count();
        int randomIndex = randomness.Next(0, length);

        return _reflectionPrompts[randomIndex];
    }
    private void reflectionQP(DateTime endTime)
    {
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            Display(GetRandomQuesiton());
            if (endTime - DateTime.Now < TimeSpan.FromSeconds(5) && endTime - DateTime.Now >= TimeSpan.FromSeconds(1))
            {
                int secondsRemaining = (int)Math.Round((endTime - DateTime.Now).TotalSeconds);
                SpinnerPause(secondsRemaining);
                Console.Write("\n");
            }
            else
            {
                Console.Write("\n");
                SpinnerPause(5);
            }
        }
    }

    public void ReflectionExercise()
    {
        DisplayStartingMessage();

        Console.Write("Get Ready...");
        SpinnerPause(5);
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following quesitons as they relate to this experience. \nYou may begin in: ");
        CountdownTimer(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        reflectionQP(endTime);
        DisplayEndingMessage();
    }
}