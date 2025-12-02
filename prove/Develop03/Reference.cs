class Reference
{
    private string _startingVerse = "";
    private string _endingVerse = "";
    private string _book = "";
    private string _chapter = "";

    public Reference()
    {
        _startingVerse = "";
        _endingVerse = "";
        _book = "";
        _chapter = "";
    }
    public Reference(string startingVerse)
    {
        _startingVerse = startingVerse;
        _endingVerse = "";
        _book = "";
        _chapter = "";
    }


    public Reference(string book, string chapter, string startingVerse, string endingVerse)
    {
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
        _book = book;
        _chapter = chapter;
    }
    public Reference(string book, string chapter, string startingVerse)
    {
        _startingVerse = startingVerse;
        _endingVerse = "";
        _book = book;
        _chapter = chapter;
    }

    public string GetReference()
    {
        if (_endingVerse != "")
        {
            char startingVerse = _startingVerse[0];
            _startingVerse = _startingVerse.Substring(2);
            char endingVerse = _endingVerse[0];
            _endingVerse = _endingVerse.Substring(2);
            return $"{_book} {_chapter}:{startingVerse}-{endingVerse}";
            
            
        }
        else
        {
            char startingVerse = _startingVerse[0];
            _startingVerse = _startingVerse.Substring(2);
            return $"{_book} {_chapter}:{startingVerse}";
        }
    }
    public string GetScripture()
    {
        if (_endingVerse != "")
        {
            return $"{_startingVerse} {_endingVerse}";
        }
        else
        {
            return _startingVerse;
        }
    }

    public void Display()
    {
        Console.Write(_book, _chapter, _startingVerse);
        if (_endingVerse != "")
        {
            Console.Write(_endingVerse);
        }
    }
}