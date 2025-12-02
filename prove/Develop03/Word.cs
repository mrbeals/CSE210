using System.Security.Cryptography.X509Certificates;

public class Word
{
    private Boolean _hidden = false;
    private string _word = "";


    public Word()
    {
        _hidden = false;
        _word = "";
    }
    public Word(string word, Boolean hidden)
    {
        _hidden = hidden;
        _word = word;
    }
    public Word(string word)
    {
        _hidden = false;
        _word = word;
    }
    public string DisplayWord()
    {
        if (_hidden)
        {
            string placeholder = "";
            foreach (char c in _word)
            {
                placeholder += "_";
            }
            return placeholder;
        }
        else
        {
            return _word;
        }
    }
    public Boolean IsHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        if (_hidden == true)
        {
            _hidden = false;
        }

    }
}