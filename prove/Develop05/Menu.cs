using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05
{
    // Importa la clase GoalsStorage si se encuentra en otro archivo
// using GoalsStorage;

    public class Menu
    {
        public List<string> goalsList = new List<string>();
        private Goals goal = new Goals();
        private Checklist checklistGoal = new Checklist();


        // Método para guardar los valores en la lista
        public void SaveGoalToList()
        {
            // Obtén los valores de las variables privadas utilizando los métodos de la instancia de Goals
            goal.SetTypeGoal(2);
            string typeGoal = goal.GetTypeGoal();
            goal.SetName();
            string name = goal.GetName();
            goal.SetDescription();
            string description = goal.GetDescription();
            goal.SetAssociatedPoints();
            int associatedPoints = goal.GetAssociatedPoints();
            if (typeGoal == "Eternal" && typeGoal == "Simple")
            {   
                bool isDone = goal.isDone;
                // Convierte los valores a cadenas (string)
                string goalString = $"{typeGoal}-{name}-{description}-{associatedPoints}-{isDone}";
                // Save goal into a list
                goalsList.Add(goalString);
            }
            else
            {
                checklistGoal.SetBonus();
                int bonus = checklistGoal.GetBonus();
                checklistGoal.SetTime();
                int time = checklistGoal.GetTime();
                string goalString = $"{typeGoal}-{name}-{description}-{associatedPoints}-{bonus}-{time}-0";
                // Save goal into a list
                goalsList.Add(goalString);
            }
        }
        public void verifyTypeGoal()
        {
            int num = 1;
            foreach (string g in goalsList)
            {
                string[] splitedGoal = g.Split('-');
                string typeGoal = splitedGoal[0];
                if(typeGoal == "Simple Goal" && typeGoal == "Eternal Goal")
                {
                    goal.DisplayGoals(goalsList, num);
                    num++;
                }
                else
                {
                    checklistGoal.DisplayGoals(goalsList, num);
                    num++;
                }
            }

        }


    }

}
