using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Develop05
{
    public class Menu
    {
        public int points = 0;
        Goals fGoals = new Goals();
        Checklist fChecklist = new Checklist();
        public string typeGoal;
        public string name;
        public string description;
        public int associatedPoints;
        public int bonus;
        public int time;
        public bool isDone = false;
        public int timeDone = 0;
        //WORKS
        public void DisplayMenu()
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }
        //WORKS
        public int GetChoice()
        {
            Console.WriteLine("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        //WORKS
        public void DisplayGoalsOptions()
        {
            Console.WriteLine("The type of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
        }
        //WORKS
        public int GetGoalOption()
        {
            Console.WriteLine("Which type of goal would you like to create?");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public void SetGoals(int option)
        {
            typeGoal = fGoals.SetTypeGoal(option);
            Console.WriteLine(typeGoal);

            if (typeGoal == "Simple Goal" || typeGoal == "Eternal Goal")
            {
                name = fGoals.GetName();
                description = fGoals.GetDescription();
                associatedPoints = fGoals.GetAssociatedPoints();
                bonus = 0;
                time = 0;
            }
            else
            {
                name = fChecklist.GetName();
                description = fChecklist.GetDescription();
                associatedPoints = fChecklist.GetAssociatedPoints();
                bonus = fChecklist.GetBonusPoints();
                time = fChecklist.GetTimeToAccomplish();
            }
        }
        public void LeastGoals(List<dynamic> goalsList, int goalNum)
        {
            string typeGoal = goalsList[0];
            string name = goalsList[1];
            string description = goalsList[2];
            int associatedPoints = goalsList[3];
            if (typeGoal == "Simple Goal" || typeGoal == "Eternal Goal")
            {
                bool isDone = goalsList[4];
                if (isDone == false)
                {
                    Console.WriteLine($"{goalNum}. [ ] {name}({description})");
                }
                else
                {
                    Console.WriteLine($"{goalNum}. [X] {name}({description})");
                }
            } 
            else
            {
                int bonus = goalsList[4];
                int time = goalsList[5];
                Console.WriteLine($"{goalNum}. [ ] {name}({description}) -- Current Completed: 0/{time}");
            }
        }
        public string GetFilename()
        {
            Console.WriteLine("What is the filename of the goal file? ");
            string filename = Console.ReadLine();
            return filename;
        }

    }
}