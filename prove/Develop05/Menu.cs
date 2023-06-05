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
                string goalString = $"{typeGoal},{name},{description},{associatedPoints},{isDone}";
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
                string goalString = $"{typeGoal},{name},{description},{associatedPoints},{bonus},{time},{done}";
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
            {   
                List<string> splitedGoal = new List<string>();
                splitedGoal.AddRange(g.Split(','));
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

        /*  ************ THIRD CHOICE *************  */
        public string GetFilename()
        {
            Console.WriteLine("What is the filename for the goal file? ");
            string name = Console.ReadLine();
            string filename = $"{name}.json";
            return filename;
        }

        public void SaveGoals()
        {
            string filename = GetFilename();
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (string g in goalsList)
                {
                    file.WriteLine(g);
                }
            }
        }

        /*  ************ FOURTH CHOICE *************  */

        public void LoadGoals()
        {
            string filename = GetFilename();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                goalsList.Add(line);
            }
        }

        /*  ************ FIFTH CHOICE *************  */

        public void DisplayGoalsToDo()
        {
            int num = 1;
            Console.WriteLine("The goals are: ");
            foreach (string g in goalsList)
            {   
                List<string> splitedGoal = new List<string>();
                splitedGoal.AddRange(g.Split(','));
                string name = splitedGoal[1];
                Console.WriteLine($"{num}. {name}");
                num++;
            }
        }
        public int GetGoalToDo()
        {
            Console.WriteLine("Which goal did you accomplish? ");
            int goalToDo = int.Parse(Console.ReadLine());
            return goalToDo;
        }

        // public void AddEvent(int goalToDo)
        // {
        //     string g = goalsList[goalToDo-1];
        //     List<string> splitedGoal = new List<string>();
        //     splitedGoal.AddRange(g.Split(','));
        //     string typeGoal = splitedGoal[0];
        //     if (typeGoal == "Eternal" || typeGoal == "Simple")
        //     {
        //         string isDone = splitedGoal[4];
        //         if (isDone.ToLower() == "false")
        //         {
        //             goal
        //         }
        //     }
        // }

        public int VerifyPoints(int goalToDo)
        {
            string g = goalsList[goalToDo-1];
            List<string> splitedGoal = new List<string>();
            splitedGoal.AddRange(g.Split(','));
            string points = splitedGoal[3];
            int intPoints = int.Parse(points);
            int generalPoints = goal.GetGeneralPoints();
            generalPoints += intPoints;
            goal.SetPoints(generalPoints);
            return intPoints; 
        }

        public void RecordEvent()
        {
            int goalToDo = GetGoalToDo();
            int earnedPoints = VerifyPoints(goalToDo);
            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
            Console.WriteLine($"You now have {goal.GeneralPoints} points.");
        }

    }

}
