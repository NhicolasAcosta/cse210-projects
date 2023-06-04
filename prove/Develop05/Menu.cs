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
                bool 
                // Convierte los valores a cadenas (string)
                string goalString = $"{typeGoal}-{name}-{description}-{associatedPoints}";
                // Save goal into a list
                goalsList.Add(goalString);
            }
            else
            {

            }
            


        }


    }

}
