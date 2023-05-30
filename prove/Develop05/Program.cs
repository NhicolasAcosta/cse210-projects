using System;
using System.Collections.Generic;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {  

            Menu fMenu = new Menu();
            Goals fGoals = new Goals();
            List<List<dynamic>> listgoalsList = new List<List<dynamic>>();

            int choice = 0;
            while(choice != 6)
            {
                fMenu.DisplayMenu();
                choice = fMenu.GetChoice();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        fMenu.DisplayGoalsOptions();
                        int option = fMenu.GetGoalOption();
                        fMenu.SetGoals(option);
                        MakeGoalList();
                        break;
                    case 2:
                        for (int i=0; i < listgoalsList.Count; i++)
                        {
                            fMenu.LeastGoals(listgoalsList[i], i+1);
                        }
                        break;
                    default:
                        Console.Write("Todavia no");
                        break;
                }
            }

            void MakeGoalList()
            {
                List<dynamic> goalList = new List<dynamic>();
                string type = fMenu.typeGoal;
                if (type == "Simple Goal" || type == "Eternal Goal")
                {
                    goalList.Add(type);
                    goalList.Add(fMenu.name);
                    goalList.Add(fMenu.description);
                    goalList.Add(fMenu.associatedPoints);
                    goalList.Add(fMenu.isDone);
                    listgoalsList.Add(goalList);
                } else
                {
                    goalList.Add(type);
                    goalList.Add(fMenu.name);
                    goalList.Add(fMenu.description);
                    goalList.Add(fMenu.associatedPoints);
                    goalList.Add(fMenu.bonus);
                    goalList.Add(fMenu.time);
                    goalList.Add(fMenu.timeDone);
                    listgoalsList.Add(goalList);                    
                }
            }


        }
    }
}
