using System;

public class Scriptures
{
    private string scripturesText;

    private References scripturesReferences;
    public Scriptures(References _scripturesReferences, string _scripturesText)
    {
        scripturesReferences = _scripturesReferences;
        scripturesText = _scripturesText;
    }


    public string toString()
        {   
            return string.Format("{0}", scripturesText);
        }
}    
