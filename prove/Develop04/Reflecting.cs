using System;

namespace Develop04
{
    public class Reflecting
    {
        private int sec;
        private List<string> animations = new List<string>{"|","/","-","\\","|","/","-","\\"};
        private List<string> message = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        private List<string> questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private void Welcome()
        {
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine("This activity will help you reflect on Times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.");
        }

        private int GetSeconds()
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            sec = int.Parse(Console.ReadLine());
            return sec;
        }

        private int TimeDiv()
        {
            int sec = GetSeconds();
            double resultado = Math.Ceiling(sec / 10.0);
            return (int)resultado;
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

        private void DisplayMessage()
        {
            int index = GetMessageIndex();
            string newMessage = message[index];
            Console.WriteLine("Consider the following prompt: ");
            Console.WriteLine($"--- {newMessage} ---");
        }

        private int GetMessageIndex()
        {
            Random rdmNum = new Random();
            int rdmIndex = rdmNum.Next(0, message.Count);
            return rdmIndex;
        }

        private bool VerifyEnter()
        {
            Console.WriteLine("When you have something in mind, press ENTER to continue...");
            bool pressedEnter = PressedTecle();
            if (pressedEnter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PressedTecle()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool verifyIndex(List<int> indexList, int indexQ)
        {
            bool verify = false;
            if (!indexList.Contains(indexQ))
            {
                verify = true;
                return verify;
            }
            return verify;
        }

        private int GetQuestionsIndex()
        {
            Random rdmNum = new Random();
            int rdmIndex = rdmNum.Next(0, questions.Count);
            return rdmIndex;
        }

        private List<int> getIndexList(int time)
        {   
            List<int> indexList = new List<int>();
            while (indexList.Count < time)
            {
                int rdmNum = GetQuestionsIndex();
                bool verify = verifyIndex(indexList, rdmNum);
                if (verify)
                {
                    indexList.Add(rdmNum);
                }
            }
            return indexList;
        }

        private void DoneMessage(int sec)
        {
            Console.WriteLine("\nWell Done!");
            Console.WriteLine($"You have completed another {sec} seconds of the breathing activity");
        }

        private void DisplayQuestion(int time)
        {
            List<int> indeQ = getIndexList(time);
            foreach (int ind in indeQ)
            {
                Console.Write($"\n{questions[ind]}");
                for (int i = 0; i < 8; i++)
                {
                    string s = animations[i];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }       
        }

        public void StartReflecting()
        {
            Welcome();
            int time = TimeDiv();
            int seconds = sec;
            GetReady();
            DisplayMessage();
            if (VerifyEnter())
            {
                DisplayQuestion(time);
                DoneMessage(sec);
            }
            else
            {
                Console.WriteLine("\nYou haven't pressed enter.");
            }
            
        }
    }
}