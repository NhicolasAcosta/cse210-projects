using System;

namespace Develop03
{
    
    public class Scripture
    {   
        public void DisplayScripture(string book, int chapter, int fVerse,int lVerse , string verses)
        {
            int verse = fVerse;
            Console.WriteLine($"{book} {chapter}: {fVerse}-{lVerse}");
            Console.WriteLine(verses);
        }

    }
}