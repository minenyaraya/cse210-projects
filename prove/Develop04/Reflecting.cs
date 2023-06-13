public class Reflecting : Activity
{
    public static string MenuMessage = "Reflecting on what we read helps us keep a mind free of negative thoughts.";
    private string _prompts;
    private string _reflecting;

    public Reflecting(string activityName,string description, int timer) : base(activityName, description, timer)
    {
        SetActivity(activityName);
        SetDescription(description);
    }
    public string GetPrompts()
    {
        return _prompts;
    }
    public string GetReflecting()
    {
        return _reflecting;
    }
    public void SetReflecting(string reflecting)
    {
        _reflecting = reflecting;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Welcome To The Activities");

        Console.WriteLine("Reflecting on what we read helps us keep a mind free of negative thoughts. Read each of the sentences, take a deep breath when you finish the sentence and apply it to your day.");
        string prompt = GetPromptFile("prompts.txt");
        Console.WriteLine(prompt);
            
        animation();
        animation();
        Console.WriteLine(" Now your are ready to write something nice. ");
        string words = Console.ReadLine();
        
        Console.WriteLine("Yay! You done. ");
    }
         
    public void DisplayReflecting()
    {
        string reflecting = GetPromptFile("prompts.txt");
        Console.WriteLine($"\n    {reflecting}   ");
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