using System;
using System.ComponentModel;
using System.Net.Quic;

// This program will not try to hide words that are already hidden. Only the words that have yet to be hid.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference(
        "Proverbs", 
        "3", 
        "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
        "6 In all thy ways acknowledge him, and he shall direct thy paths.");
        string fullReference = reference.GetReference();

        string scriptureReference = reference.GetScripture();

        Scripture scripture = new Scripture(fullReference, scriptureReference);
        scripture.GetRenderedText();

        string input = "";
        while (scripture.IsFinished() == false && input != "quit")
        {
            scripture.Display();
            scripture.HideWords();
            input = Console.ReadLine();
            input = input.ToLower();
        }
        scripture.Display();
    }
}