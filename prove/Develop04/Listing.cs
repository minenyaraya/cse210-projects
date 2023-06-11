public class Listing : Activity
{
    private string _prompt;

    public Listing(string activityName, string description):base(activityName, description)
    {
        base.SetActivityName(activityName);
        base.SetDescription(description);
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }
    public void DisplayPrompt()
    {
        string prompt = GetPrompt("prompy.txt");
        Console.WriteLine("Listing : The positive words helps us recognize the details of thoughts. With the sentence you read, make a list of uplifting words that come to mind.");
        Console.WriteLine($"    {prompt}   ");
        Console.WriteLine("Time to write positive words: ");
        Console.WriteLine("Welcome To The Activities");
        
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
           Thread.Sleep(6000);
           Console.Write("\n ");
        }


        Console.WriteLine("Yay! You done. ");
        public void CountWords(int timer)
        {
            Console.Write("*-*");
            Console.ReadLine();
            AddWords();

            public void DisplayWords()
            {
                int words = GetWords();
                Console.WriteLine($" You write {words} words! ");
            }
        }
    
    }     

        
    }
}