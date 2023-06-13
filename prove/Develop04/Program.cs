using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        
        bool Quit = false;
        while(Quit == false)
        {
            // Console.Clear();
            Console.WriteLine("Choose one activity:");
            Console.WriteLine("1 - Breathing");
            Console.WriteLine("2 - Listing");
            Console.WriteLine("3 - Reflecting");
            Console.WriteLine("4 - Quit");
            string userChoise= Console.ReadLine();
            
            switch (userChoise)
            {
                case "1": 

                Console.WriteLine(Breathing.MenuMessage); 
                Breathing breathing = new Breathing("Breathing", "Desccription", 60);
                breathing.Breath();
                Console.Clear();
                break;

                case "2":
                Console.WriteLine(Listing.MenuMessage);
                Listing listing = new Listing("Listing", "Description",60);
                listing.DisplayPrompt();
                break;

                case "3":
                Console.WriteLine(Reflecting.MenuMessage);
                Reflecting reflecting = new Reflecting("Reflecting", "Description", 60);
                reflecting.DisplayPrompt();
                break;

                case "4":
                Quit=true;
                Console.Clear();
                Console.WriteLine("Goodbye");
              
                break;
                
            }

        }
        

    }     
}
