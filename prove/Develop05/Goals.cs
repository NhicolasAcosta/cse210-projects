using System;
using System.Collections.Generic;

namespace Develop05
{
    public class Goals
    {

        //WORKS
        public string GetName()
        {
            Console.WriteLine("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            return goalName;
        }
        //WORKS
        public string GetDescription()
        {
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            return description;
        }
        //WORKS
        public int GetAssociatedPoints()
        {
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int associatedPoints = int.Parse(Console.ReadLine());
            return associatedPoints;
        }
        //works        
        public string SetTypeGoal(int option)
        {
            string typeGoal;
            switch(option)
            {
                case 1:
                    typeGoal = "Simple Goal";
                    break;
                case 2: 
                    typeGoal = "Eternal Goal";
                    break;
                case 3:
                    typeGoal = "Checklist Goal";
                    break;
                default:
                    Console.WriteLine("You didn't choose an correct option");
                    typeGoal = "";
                    break;
            }
            return typeGoal;
        }
    }
}