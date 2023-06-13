public class Listing : Activity
{
    private string _prompts;
    public static string MenuMessage = "Listening to positive words helps us recognize the details of thoughts. With the sentence you read, make a list of uplifting words that come to mind.";

    public Listing(string activityName, string description, int timer) : base(activityName, description, timer)
    {
        SetActivity(activityName);
        SetDescription(description);
    }
    public string GetPrompts()
    {
        return _prompts;
    }
    public void SetPrompt(string prompts)
    {
        _prompts = prompts;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Welcome To The Activities");
        Console.WriteLine("Listing : The positive words helps us recognize the details of thoughts. With the prompt you read, make a list of uplifting words that come to mind.");
        string prompt = GetPromptFile("prompts.txt");
        Console.WriteLine($"    {prompt}   ");
        Console.WriteLine("Time to write positive words: ");
        
        CountWords();

        // animation();

        Console.WriteLine("Yay! You done. ");
    }
    public void CountWords()
    {
        Console.Write("*-*");
        string words = Console.ReadLine();
        int count = AddWords(words);
        DisplayWords(count);
    }
    public void DisplayWords(int count)
    {
        Console.WriteLine($" You wrote {count} words! ");
        Thread.Sleep(1000);
    }
    public int AddWords(string words) {
        string[] wordArray = words.Split(" ");
        return wordArray.Length;
    }
     public void animation() 
    {
        ///>\*|*/<
        List<string> animacionStrings = new List<string>();
        animacionStrings.Add(" >");
        animacionStrings.Add("\\");
        animacionStrings.Add("*_*");
        animacionStrings.Add("|");
        animacionStrings.Add("*_-");
        animacionStrings.Add("/");
        animacionStrings.Add(">");

        foreach (string s in animacionStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\n ");
        }
    }
        
}
