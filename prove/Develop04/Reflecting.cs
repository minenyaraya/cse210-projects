public class Reflecting : Activity
{
    private string _prompt;
    private string _reflecting;

    public Reflecting(string activityName,string description): base(activityName,description)
    {
        base.SetActivityName(activityName);
        base.SetDescription(description);
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
        string prompt = base.getPromptsFile("Prompts.tex");
        Console.WriteLine("Reflecting on what we read helps us keep a mind free of negative thoughts. Read each of the sentences, take a deep breath when you finish the sentence and apply it to your day.");
        Console.WriteLine(" Now your are ready to write something nice. ");

        Console.    WriteLine("Welcome To The Activities");
            Console.WriteLine("Slowly inhale and exhale.");
            
        
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
                Thread.Sleep(5000);
                Console.Write("\n ");
            }
            Console.WriteLine("Yay! You done. ");
            {
                public void DisplayReflecting(int timer)
                {
                    string reflecting = base.GetPromptsFile("Promt.txt");
                    Console.WriteLine($"\n    {reflecting}   ");
                    base.ShowSpiner(5);
                }
            }
         



    }
}