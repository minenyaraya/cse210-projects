public class Breathing:Activity
{
    public Breathing(int timer, string activityName, string description,):base(activityName,description)
    {
        base.SetActivityName(activityName);
        base.SetDescription(description);
    }
        public void Breath()
        {   Console.    WriteLine("Welcome To The Activities");
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
                Thread.Sleep(1000);
                Console.Write("\n ");
            }
            Console.WriteLine("Yay! You done. ");
        }
    }     
        
    
