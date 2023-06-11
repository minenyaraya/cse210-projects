using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
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
           Thread.Sleep(1000);
           Console.Write("\n ");
        }


        Console.WriteLine("Yay! You done. ");
    
    }     
}
