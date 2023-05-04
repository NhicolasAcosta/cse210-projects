using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Usuario
    {
        Journal newJournal = new Journal();
        //Function to obtain the choice about what the user wants to do
        public int getUserChoice()
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("");
            //Function readline return a string date, so int.Parse convert it into a interger date
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        //Main function in the program
        public dynamic verifyChoice(int choice, string phrase, List<string> writingList)
        {
            if (choice == 1)
            {
                //User wants to write something new in the journal
                return choice1(phrase, writingList);
            }
            else if (choice == 2)
            {
                //User wants to display what he/she is writing  for now
                return choice2(writingList, phrase);
            }
            else if (choice == 3)
            {
                //User wants to read a text file created in the past
                return choice3();
            }
            else if (choice == 4)
            {
                //User wants to save what he/she wrote
                return choice4(writingList, phrase);
            }
            else
            {
                //Sorry, I didn't know how to finish the loop without returning something
                return writingList;
            }
        }
        public dynamic choice1( string phrase, List<string> writingList)
        {
            Console.WriteLine(phrase);
            writingList.Add(Console.ReadLine());
            return writingList;
        }
        public dynamic choice2(List<string> writingList, string phrase)
        {
            if (writingList.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Todavia no escribiste nada.");
                Console.WriteLine("");
            }
            else
            {
                DateTime dateToday = DateTime.Today;
                string dateTodayString = dateToday.ToString("yyyy-MM-dd");

                for (int i = 0; i < writingList.Count; i++)
                {
                    Console.WriteLine(dateTodayString);
                    Console.WriteLine(phrase);
                    Console.WriteLine(writingList[i]);
                    Console.Write("");
                }
            }
            return writingList;
        }
        public dynamic choice3()
        {
            
            string nameFile = getFileToRead();
            newJournal.readFile($"{nameFile}.txt");
            Console.WriteLine("");
            return nameFile;
        }
        public dynamic choice4(List<string>writingList, string phrase)
        {
            string newFileName = getFileToCreate();
            DateTime dateToday = DateTime.Today;
            string dateTodayString = dateToday.ToString("yyyy-MM-dd");
            newJournal.createFile(newFileName, writingList, dateTodayString, phrase);
            Console.WriteLine("");
            string message = $"File {newFileName}.txt created.";
            Console.WriteLine("");
            return message;
        }
        public string getFileToRead()
        {
            Console.WriteLine("What is the name of the file you want to read?");
            Console.WriteLine("");
            return Console.ReadLine();
        }
        public string getFileToCreate()
        {
            Console.WriteLine("What is the name of your new file?");
            Console.WriteLine("");
            return Console.ReadLine();
        }
    }
}

