using System;

namespace Develop04
{
    public class Listing
    {
        private int sec;
        private List<string> animations = new List<string>{"|","/","-","\\","|","/","-","\\"};
        private List<string> questions = new List<string>{
           "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private void Welcome()
        {
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        private int GetSeconds()
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            sec = int.Parse(Console.ReadLine());
            return sec;
        }

        private void GetReady()
        {
            int i = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);
            Console.Write("Get ready! ");
            while (DateTime.Now < endTime)
            {
                string s = animations[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                            
                i++;
                if(i >= animations.Count)
                {
                    i = 0;
                }
            }

        }

        private int GetQuestionsIndex()
        {
            Random rdmNum = new Random();
            int rdmIndex = rdmNum.Next(0, questions.Count);
            return rdmIndex;
        }

        private void DoneMessage(int sec, int quantity)
        {
            Console.WriteLine($"You listed {quantity} items!");
            Console.WriteLine("\nWell Done!");
            Console.WriteLine($"You have completed another {sec} seconds of the breathing activity");
        }

        private void GetResponse()
        {
            Console.Write("\n> ");
            string entrada = Console.ReadLine();
        }

        private int DisplayQuestion(int sec)
        {
            int respQuantity = 0;
            int questionIndex = GetQuestionsIndex();
            string question = questions[questionIndex];
            Console.WriteLine("List as many responses you can to the following prompt: ");
            Console.Write($"\n--- {question} ---");
            Console.Write("\nYou may begin in: ");
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(sec);

            while (DateTime.Now < endTime)
            {
                GetResponse();
                respQuantity++;
            }
            return respQuantity;
        }

        public void StartListing()
        {
            Welcome();
            int sec = GetSeconds();
            GetReady();
            int quantity = DisplayQuestion(sec);
            DoneMessage(sec,quantity);
        }
    }
}