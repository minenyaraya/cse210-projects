using System;

public class References
{
    private string book,chapter, verse;
        public References (string _book,  string _chapter, string _verse)
        {
            book = _book;
            chapter = _chapter;
            verse = _verse;
        }
        public string toString()
        {
            return string.Format("{0}, {1}: {2}" , book, chapter, verse);
        }
}