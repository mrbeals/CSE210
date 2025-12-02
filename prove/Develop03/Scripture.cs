class Scripture
{
    private List<Word> _scripture = new List<Word>();
    private string _reference = "";
    private string _verse = "";

    public Scripture()
    {
        _scripture = new List<Word>();
        _reference = "";
        _verse = "";
    }
    public Scripture(string reference)
    {
        _reference = reference;
        _scripture = new List<Word>();
        _verse = "";
    }
    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _scripture = new List<Word>();
        _verse = verse;
    }
    public void Display()
    {
        Console.Clear();
        Console.Write($"{_reference} ");
        foreach (Word i in _scripture)
        {
            Console.Write($"{i.DisplayWord()} ");
        }
        Console.WriteLine("\nPress enter to continue, type quit to quit.");
    }
    public void HideWords()
    {
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            
            int selection = random.Next(_scripture.Count);
            if (_scripture[selection].IsHidden()) {
                if (!IsFinished())
                {i -= 1;}
            }
            else
            {
            _scripture[selection].Hide();
            }
        }
    }

    public void GetRenderedText()
    {
        string[] words = _verse.Split(" ");

        foreach (string word in words)
        {
            _scripture.Add(new Word(word));
        }
        


    }
    
    public Boolean IsFinished()
    {
        foreach (Word w in _scripture)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }

        }
        return true;
    }
}   