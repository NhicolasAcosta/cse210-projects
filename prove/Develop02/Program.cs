using System;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario newUser = new Usuario();
            Journal newJournal = new Journal();
            List<string> writingList = new List<string>();
            Console.WriteLine("Welcome to the Journal Program!");
            int choice = 1;
            while (choice != 5)
            {
                choice = newUser.getUserChoice();
                string phrase = newJournal.displayPhrase();
                dynamic verification = newUser.verifyChoice(choice, phrase, writingList);
            }
            Console.WriteLine("Thank you. See you soon!");
        }
    }
}