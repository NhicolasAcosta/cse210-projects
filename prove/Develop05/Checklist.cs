using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05
{
    public class Checklist:Goals
    {
        private int bonus;
        private int time;

        /********** BONUS ***********/
        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public void SetBonus()
        {
            Console.WriteLine("What is the bonus for accomplishing it that many time? ");
            bonus = int.Parse(Console.ReadLine());
        }
        public int GetBonus()
        {
            return bonus;
        }

        /********** TIME ***********/
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public void SetTime()
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            time = int.Parse(Console.ReadLine());
        }
        public int Gettime()
        {
            return time;
        }
        public override void DisplayGoal(List<string> goalsList)
        {
            Console.WriteLine("The Goals are: ");
            
        }
    }
}
