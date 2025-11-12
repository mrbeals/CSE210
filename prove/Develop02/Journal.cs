using System.Runtime.CompilerServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public Dictionary<string, string> entries = new Dictionary<string, string>();

    public static void AddEntry(Dictionary<string, string> entries)
    {
        string prompt = PromptGenerator.RandomChoice();
        PromptGenerator.Display(prompt);

        string entry = Console.ReadLine();

        DateTime dateint = DateTime.Now;
        string date = dateint.ToString();

        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
        newEntry._content = entry;
        newEntry._date = date;

        entries[newEntry._date] = $"Prompt: {newEntry._prompt} \\n{newEntry._content}";
        
    }

    public static Dictionary<string, string> Load()
    {
        Console.WriteLine("What is the name of your journal file?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        Dictionary<string, string> entries = new Dictionary<string, string>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",", 2);

            string key = parts[0];
            string value = parts[1];
            entries[key] = value;
        }
        return entries;
    }


    public static void Save(Dictionary<string, string> entries)
    {
        Console.WriteLine("What is the name of your journal file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            foreach (var entree in entries)
            {
                outputFile.WriteLine($"{entree.Key},{entree.Value}");
            }
        }
    }
}