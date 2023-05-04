using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public string displayPhrase()
        {
            List<string> phrases = new List<string>();
            phrases.Add("Who was the most interesting person I interacted with today?");
            phrases.Add("What was the best part of my day?");
            phrases.Add("How did I see the hand of the Lord in my life today?");
            phrases.Add("What was the strongest emotion I felt today?");
            phrases.Add("If I had one thing I could do over today, what would it be?");
            //The random number is to display a random phrase to the user
            Random rdm = new Random();
            int rdmNum = rdm.Next(1,5);
            return phrases[rdmNum];
        }
        public void createFile(string fileName, List<string>writingList, string dateToday, string phrase)
        {
            //through this function we can verify if there is any another file with the same name
            if (!File.Exists($"{fileName}.txt"))
            {
                using (StreamWriter sw = File.CreateText($"{fileName}.txt"))
                {
                    for (int i = 0; i < writingList.Count; i++)
                    {
                        sw.WriteLine($"{dateToday}- {phrase}");
                        sw.WriteLine(writingList[i]);
                        sw.WriteLine("");
                    }
                }
            } else 
            {
            Console.WriteLine("There is a file with the same name, please choose another name");  
            }
        }
        public void readFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry! The name wrote doesn't exist");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}