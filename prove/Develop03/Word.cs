using System;

public class Word
{
    private string _references;
    private string _scriptures;

    public Word()
    {
        _references = "Unknown";
        _scriptures = "Unknown";
    }
    public Word(string referencesToInput)
    {
        _references = referencesToInput;
        _scriptures = "";
    }
    public Word( string referencesToInput, string scripturesToInput)
    {
        _references = referencesToInput;
        _scriptures = scripturesToInput;
    }
    public string TotalWords()
    {
        string totalW = _references + " " + _scriptures;
        return totalW;
    }    
}