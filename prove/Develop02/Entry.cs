using System;
using System.Collections.Generic;
using System.IO;
public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _text = "";
    public string _hour = "";
    public Entry (string prompt, string text, string date, string hour) {
        _prompt = prompt;
        _text = text;
        _date = date;
        _hour = hour;
    }

    public void DisplayEntry () {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_text);
        Console.WriteLine("Hour: " + _hour);
    }
    public static void CreateEntry()
    {

        
        // Console.WriteLine($"{journalQuestions(mIndex),{Journal}}");
        string JournalCombine = Console.ReadLine();
        string currentDate1 = DateTime.Now.ToString("MM/DD/YYYY");

        Console.WriteLine("What is the file name: ");
        string fileInput = Console.ReadLine();
        string fileName = fileInput;

        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            outputFile.WriteLine("This will be the first line in the file. ");

            outputFile.WriteLine($" {currentDate1} {JournalCombine}");
        }
    }
}