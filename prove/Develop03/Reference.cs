using System;

namespace Develop03

{
    
    public class Reference
    {
        public string Book;
        public int Chapter;
        public int FVerse;
        public int LVerse;
        public string VerseContent;

        public Reference(string book, int chapter, int fVerse, int lVerse, string verseContent)
        {
            Book = book;
            Chapter = chapter;
            FVerse = fVerse;
            LVerse = lVerse;
            VerseContent = verseContent;

        }

        //This function returns if the user wants to continue
        public bool getUserChoice()
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userChoice = Console.ReadLine();
            if(userChoice.ToLower() != "quit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}