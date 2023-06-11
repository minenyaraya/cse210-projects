using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Program
{
    // public List<string> choose=>new List<string>();
    public static PromptGenerator promptGenerator;
    public static Journal journal;
    static void Main(string[] args)
    {
        promptGenerator = new PromptGenerator();
        journal = new Journal();

        int input = 0;
        int running = 0;

        while (running == 0)
        {
            Console.WriteLine("Hello friend, wellcome to my Journal ");
            Console.WriteLine(" Please choose What do you like to do :");
            Console.WriteLine(" 1 - Write : ");
            Console.WriteLine(" 2 - Display :");
            Console.WriteLine(" 3 - Load :");
            Console.WriteLine(" 4 - Save :");
            Console.WriteLine(" 5 - Quit :");
            input = Convert.ToInt32(Console.ReadLine());
            
            if(input == 1)
            {
                Write();
            }
            else if (input == 2)
            {
                Display();
            }
            else if (input == 3)
            {
                Load();
            }
            else if (input == 4){
                Console.WriteLine("saving...");
                Save();
            }
            else if (input == 5){
                Console.WriteLine ("Bye");
                running = 1;
            }
        }
             
    }
    public static void Write()
    {
        Console.WriteLine("Please write: ");
        string prompt = promptGenerator.DisplayPrompt();
        Console.WriteLine(prompt);
        string text = Console.ReadLine();
        Console.WriteLine("Enter the hour :");
        string hour = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        journal.AddEntry(prompt, text, dateText, hour);
    }
    public static void Display()
    {
        Console.WriteLine("Display all: ");

        journal.DisplayingEntries();
    }
    public static void Load() 
    {
        Console.WriteLine("Loading...");
        journal.LoadFromFile();
    }

    public static void Save() {
        Console.WriteLine("Saving...");
        journal.SaveToFile();
    } 


}