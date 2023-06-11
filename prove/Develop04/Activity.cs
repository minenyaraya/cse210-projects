using System;
{
    
}
public class Activity
{
    private string _activityName;
    private string _description;
    private string _Timer;
    provate int  _spinnerCounter = 0;
    private List<int> _usedPrompts = new List<int>();
  

    public Activity (string _activityName, string _description, int timer)
    {
       SetActivity(activityName);
       SetDescription(description);
    }

    private void SetDescription(object description)
    {
        throw new NotImplementedException();
    }

    private void SetActivity(object activityName)
    {
        throw new NotImplementedException();
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    private void getTimer;

    public void GetTimer { get => getTimer; set => this.getTimer = value; }
}
        return _timer()
    {
      public void SetTimer(int timer);
      {
            _timer = timer;
      }
      public string GetDescription()

      {
        return _description;
      }
      public void SetDescription(string description)
      {
        _description = description;
      }
      public int GetSpinnerCounter;
      {
        return _spinerCounter;
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

        Console.Clear();Console.Write($"Welcome to the {activityName}.\n{Description}\nHowlong, in seconds, would you like for your activity? ");string userInput = Console.ReadLine();int activityTime = int.Parse(userInput);SetTimer(Timer);Console.WriteLine("\nGet Ready...");ShowSpinner(3);
      }
      public void DisplayFinale()
      {
        string activityName = GetActivityName();
        int Timer = GetTimer();Console.WriteLine($"\nWell Done!\n\nYou have completed another {Timer}seconds of {activityTitle}");ShowSpinner(5);
      }
      public void Pause(int pausetimer)
      {
        Stopwatch stopwatch = stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapseMillseconds < pausetimer * 1000)
        {
            Console.Write(pauseTime - (stopwatch.ElapsedMilliseconds /1000));Console.SetCursorPosition(Console.CursorLeft - 1 , Console.CursorTop);Thread.Sleep(1000)
        }
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
        string[] prompts = System.IO.File.ReadAllLines(fileName);

        int lenght = prompts.Length;
        Random rnd= new Random();
        int i = rnd.Next(lenght);
        List<int> usedPrompts = GetUsedPrompts();

        if(usedPrompts.Count == lenght){Console.WriteLine("You answered all the prompts!");Thread.Sleep(3000);ResetUsedPrompts();}while(usedPrompts.Contains(i))
        {
            i = rnd.Next(lenght);
        }return prompts[i];
      }  
}     



   


}