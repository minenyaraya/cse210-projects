public class Breathing:Activity
{
    public static string MenuMessage = "Breathing Activity, Breathing helps us relax the mind and body.";
    public Breathing( string activityName, string description,  int timer) : base(activityName, description, timer)
    {
        SetActivity(activityName);
        SetDescription(description);
    }
    public void Breath()
    {   
        Console.WriteLine("Welcome To The Activities");
        Console.WriteLine("Slowly inhale and exhale.");
        Console.WriteLine(" Now is ... > inhale");
        animation();
       
        
        Console.WriteLine("Now is... > exhale ");
        animation();
        

        Console.WriteLine("Yay! You done. ");
        Thread.Sleep(500);
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
        
    
