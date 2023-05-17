using System;
using System.Text;

namespace Develop03
{
    public class Word
    {

        //This is the main function, using 3 other function and return a modified text
        public string makeNewText(string verse, List<int> indexList){
            int quantity = getQuantity(verse);
            List<int> newIndexList = getIndexList(indexList, quantity);
            string newText = getNewText(newIndexList, verse);
            return newText;
        }

        //Here we get just a random number
        public int getRandonNum(int quantity)
        {
            Random rdm = new Random();
            int num = rdm.Next(0, quantity);
            return num;
        }

        //This function make a list with index to use to modify the verse
        public List<int> getIndexList(List<int> indexList, int quantity)
        {
            for (int i = 0; i < 4; i++)
            {
                int rdmNum = getRandonNum(quantity);
                bool verify = verifyIndex(indexList, rdmNum);
                if (verify)
                {
                    indexList.Add(rdmNum);
                }
            }
            return indexList;
        }

        //This function checks if the random number is already in the list
        public bool verifyIndex(List<int> indexList, int index)
        {
            bool verify = false;
            if (!indexList.Contains(index))
            {
                verify = true;
                return verify;
            }
            return verify;
        }

        //It receive a text a return a word list
        public List<string> splitVerse(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordList = new List<string>(words);
            return wordList;
        }

        //It joins the word list to display by another function
        public string joinWord(List<string> verseList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < verseList.Count(); i++)
            {
                sb.Append(verseList[i]);
                if (i < verseList.Count() - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }

        //This function will modify the text 
        public string getNewText(List<int> indexList, string text)
        {
            List<string> wordList = splitVerse(text);
            foreach (int index in indexList)
            {
                wordList[index] = "----";
            }
            string newText = joinWord(wordList);
            return newText;
        }

        //It returns the number of words in the wordlist
        public int getQuantity(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        //Right now we check if there are still words to replace
        public bool verifyText(string text)
        {
            List<string> wordList = splitVerse(text);
            bool finish = true;
            foreach (string word in wordList)
            {
                if (word != "----")
                {
                    finish = false;
                }
            }
            return finish;
        }

    }
}
