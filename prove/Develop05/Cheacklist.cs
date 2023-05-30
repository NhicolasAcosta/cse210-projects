using System;
using System.Collections.Generic;

namespace Develop05
{
    public class Checklist:Goals
    {
        public int GetTimeToAccomplish()
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int time = int.Parse(Console.ReadLine());
            return time;
        }
        public int GetBonusPoints()
        {
            Console.WriteLine("What is the bonus for accomplishing it that many time? ");
            int bonus = int.Parse(Console.ReadLine());
            return bonus;
        }
        // public override void SetGoals(string name, string description, int associatedPoints, int bonus, int time)
        // {
        //     name = GetName();
        //     description = GetDescription();
        //     associatedPoints = GetAssociatedPoints();
        //     bonus = GetBonusPoints();
        //     time = GetTimeToAccomplish();
        // }
    }
}