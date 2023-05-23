using System;

namespace Develop04
{
    public class Breathing
    {
        private int sec;
        private List<string> animations = new List<string>{"|","/","-","\\","|","/","-","\\"};

        //Tested - WORKS!
        private void Welcome()
        {
            Console.WriteLine("Welcome to the Breathing Activity");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing...");
        }

        //Tested - WORKS!
        private int GetSeconds()
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            sec = int.Parse(Console.ReadLine());
            return sec;
        }
        //Tested - WORKS!
        private int TimeDiv(int numero)
        {
            double resultado = Math.Ceiling(numero / 2.0);
            resultado = Math.Ceiling(resultado / 5.0);
            return (int)resultado;
        }

        //Tested - WORKS!
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

        //Tested - WORKS!
        private void BreatheIn()
        {
            Console.Write("\nBreathe in...");
            for (int i = 5; i > 0; i--)
            {
                string s = animations[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        //Tested - WORK!
        private void BreatheOut()
        {
            Console.Write("\nBreathe out...");
            for (int i = 5; i > 0; i--)
            {
                string s = animations[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        //Tested - WORKS!
        private void DoneMessage(int sec)
        {
            Console.WriteLine("\nWell Done!");
            Console.WriteLine($"You have completed another {sec} seconds of the breathing activity");
        }

        //Tested - WORKS!
        public void StartBreathing()
        {
            Welcome();
            int sec = GetSeconds();
            int time = TimeDiv(sec);
            GetReady();
            for (int i = 0; i < time; i++)
            {
                BreatheIn();
                BreatheOut();
                Console.WriteLine("");
            }
            DoneMessage(sec);
            
        }
    }
}