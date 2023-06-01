using System;


class Program
{
        static void Main(string[] args)
    {
        References scripturesReferences = new References("Jacob","3", "2");
        Scriptures scriptures= new Scriptures (scripturesReferences, "if your bminds are firm, forever.");
        Thescripture thescripture = new Thescripture (scriptures);

        string userInput = "";

        while (userInput != "done" && thescripture.hasWordsLeft()== true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scripturesReferences.toString(), thescripture.toString()));
            Console.WriteLine();
            Console.ReadLine();
            thescripture.removeWordsFromList();
        }
    }
}