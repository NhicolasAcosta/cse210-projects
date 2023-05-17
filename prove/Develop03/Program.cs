using System;
using System.IO;
using System.Collections.Generic;

namespace Develop03
{

    class Program
    {
        static void Main(string[] args)
        {
            //This is the verse we'll use to display
            string verse = ("Trust the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");
            List<int> indexList = new List<int>();
            //Set the atributes of the classes
            Reference ref1 = new Reference("Proverbs",3,5,6,verse);
            Scripture scrip1 = new Scripture();
            Word word1 = new Word();


            scrip1.DisplayScripture(ref1.Book, ref1.Chapter, ref1.FVerse, ref1.LVerse, verse);
            bool answer = true;
            //This condition tell us if the user wants to continue with the program or finish it
            while (answer == true)
            {
                //This function will return the user choice about the previous condition
                answer = ref1.getUserChoice();
                if (answer)
                {
                    //here we use most of the functions of the classes
                    string newText = word1.makeNewText(verse, indexList);
                    //Now it display the modified text
                    scrip1.DisplayScripture(ref1.Book,ref1.Chapter,ref1.FVerse, ref1.LVerse,newText);
                    //Right now we check if there are still words to replace
                    bool verification = word1.verifyText(newText);
                    if (verification)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Program finished. Thank you!");  

        }   
    }
}