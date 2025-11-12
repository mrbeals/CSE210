

class Entry
{

    public string _prompt = "";

    public string _content = "";

    public string _date = "";

    public static void Display(Dictionary<string, string> entries)
    {
        foreach (var entree in entries)
        {

            Console.WriteLine($"Date: {entree.Key.Substring(0, 10)} - {entree.Value.Replace("\\n", "\n")}\n");
        }
        
    }

}