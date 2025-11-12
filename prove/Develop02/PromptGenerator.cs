class PromptGenerator
{


    public static string RandomChoice()
    {

        List<string> promptList = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Something I am grateful for is: ",
            "Something I did to serve someone was: ",
            "A goal I have is: ",
            "I felt Happy when: "
            };

        Random randomness = new Random();
        int length = promptList.Count();
        int randomIndex = randomness.Next(0, length);

        return promptList[randomIndex];
    }

    public static void Display(string prompt)
    {
        Console.WriteLine(prompt);
    }
}