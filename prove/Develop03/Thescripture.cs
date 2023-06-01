using System;
public class Thescripture
{
    private const string V = "_";
    private Scriptures Scriptures;

   private List<string> scripturesTextList;
   public Thescripture (Scriptures _scriptures)
   {
      Scriptures = _scriptures;
      scripturesTextList = new List<string>();
      convertTextToList();
   }
   private void convertTextToList()
   {
      scripturesTextList = Scriptures.ToString().Split(" ").ToList();
   }

   public void removeWordsFromList()
   {
      int numWordsToRemove = new Random().Next(3);
      int wordsRemoved = 0;

      do
      {
         int randomIndex = new Random(). Next(0, scripturesTextList.Count());
         if (scripturesTextList[randomIndex].Contains("_") != false)
         {
            scripturesTextList[randomIndex] = new string ("_" + scripturesTextList[randomIndex].Length);
            wordsRemoved++;
         }
         
      }while (wordsRemoved != numWordsToRemove);
   }
   public string toString()
   {
      return String .Join(" ", scripturesTextList);
   }
   public bool hasWordsLeft()
   {
      bool retvalue = false;

      foreach (string word in scripturesTextList)
      {
         if (word.Contains("_") == false)
         {
            retvalue = true;
            break;
         }
      }
      return retvalue;
   }

}