using System;
using System.IO;
public class Activity
{
    protected string _activityName;
    protected string _description;
    protected List<int> _usedPrompts = new List<int>();
  

    public Activity (string activityName, string description, int timer)
    {
       SetActivity(activityName);
       SetDescription(description);
    }

    protected void SetDescription(string description)
    {
      _description = description;
    }

    protected void SetActivity(string activityName)
    {
      _activityName = activityName;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

      public string GetDescription()
      {
        return _description;
      }
      public void AddUsedPrompts(int promptsIndex)
      {
        _usedPrompts.Add(promptsIndex);
      }
      public List<int> GetUsedPrompts()
      {
        return _usedPrompts;
      }
      public void ResetUsedPrompts()
      {
        _usedPrompts.Clear();
      }
      public void DisplayMessage()
      {
        string activityName = GetActivityName();
        string description = GetDescription();

        Console.Clear();
        Console.Write($"Welcome to the {activityName}.\n{_description}\n ");
        Console.WriteLine("\nGet Ready...");
       
      }
      public void DisplayFinale()
      {
        string activityName = GetActivityName();
        Console.WriteLine($"\nWell Done!\n\nYou have completed another activity");
      }
      public void Pause(int pausetimer)
      {
        Console.WriteLine("Follow me");
        
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


        Console.WriteLine("Yay! You done. ");
      }
      public string GetPromptFile(string fileName)
      {
        string[] prompts = File.ReadAllLines(fileName);

        int lenght = prompts.Length;
        Random rnd= new Random();
        int i = rnd.Next(lenght);
        List<int> usedPrompts = GetUsedPrompts();

        if(usedPrompts.Count == lenght)
        {
          // Console.WriteLine("You answered all the prompts!");
          // Thread.Sleep(3000);ResetUsedPrompts();
          // }
          while(usedPrompts.Contains(i))
          {
            i = rnd.Next(lenght);
          }
        }
        usedPrompts.Add(i);
        return prompts[i];
      }  
}     
