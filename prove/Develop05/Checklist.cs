using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05
{
    public class Checklist:Goals
    {
        private int bonus;
        private int time;
        private int done = 0;

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
        public int GetTime()
        {
            return time;
        }

        /********** TIME ***********/
        public int GetDone()
        {
            return done;
        }


        public override void DisplayGoals(List<string> splitedGoal, int num)
        {
            Console.WriteLine("The Goals are: ");
                string typeGoal = splitedGoal[0];
                string name = splitedGoal[1];
                string description = splitedGoal[2];
                string associatedPoints = splitedGoal[3];
                string bonus = splitedGoal[4];
                string time = splitedGoal[5];
                string done = splitedGoal[6];

                Console.WriteLine($"{num}. [ ] {name} ({description}) --- Current completed: {done}/{time}");

                num++;
        }

    }
}
