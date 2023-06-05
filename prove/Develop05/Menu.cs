using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05
{

    public class Menu
    {
        public List<string> goalsList = new List<string>();
        private Goals goal = new Goals();
        private Checklist checklistGoal = new Checklist();



        /********** MAIN MANU ***********/
        public void DisplayMenu()
        {
            int points = goal.GetGeneralPoints();
            Console.WriteLine($"You have {points}");
            Console.WriteLine("Menu Option: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }
        public int GetChoice()
        {
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        /********* TYPE OF GOAL OPTION ***********/

        public void TypeGoalOptions()
        {
            goal.DisplayTypeGoalOption();
            goal.SetTypeGoal();
        }

        // METHOD TO SAVE VALUES INTO THE LIST
        public void SaveGoalToList()
        {
            string typeGoal = goal.GetTypeGoal();
            goal.SetName();
            string name = goal.GetName();
            goal.SetDescription();
            string description = goal.GetDescription();
            goal.SetAssociatedPoints();
            int associatedPoints = goal.GetAssociatedPoints();
            if (typeGoal == "Eternal" || typeGoal == "Simple")
            {   
                bool isDone = goal.isDone;
                // CONVERT VALUES INTO STRING
                string goalString = $"{typeGoal}-{name}-{description}-{associatedPoints}-{isDone}";
                // SAVE GOAL INTO THE LIST
                goalsList.Add(goalString);
            }
            else
            {
                checklistGoal.SetBonus();
                int bonus = checklistGoal.GetBonus();
                checklistGoal.SetTime();
                int time = checklistGoal.GetTime();
                int done = checklistGoal.GetDone();
                string goalString = $"{typeGoal}-{name}-{description}-{associatedPoints}-{bonus}-{time}-{done}";
                // SAVE GOAL INTO THE LIST
                goalsList.Add(goalString);
            }
        }

        /*  ************ FIRST CHOICE *************  */
        public void CreateNewGoal()
        {
            TypeGoalOptions();
            SaveGoalToList();
        }


        /*  ************ SECOND CHOICE *************  */
        public void LeastGoals()
        {
            int num = 1;
            Console.WriteLine("The Goals are: ");
            foreach (string g in goalsList)
            {   List<string> splitedGoal = new List<string>();
                splitedGoal.AddRange(g.Split('-'));
                string typeGoal = splitedGoal[0];
                if(typeGoal == "Simple" || typeGoal == "Eternal")
                {
                    goal.DisplayGoals(splitedGoal, num);
                    num++;
                }
                else
                {
                    checklistGoal.DisplayGoals(splitedGoal, num);
                    num++;
                }
            }
        }



    }

}
