using System.Collections.Generic;

namespace Develop05
{

    public static class GoalsStorage
    {
        public static List<string> SavedGoals = new List<string>();

        public static void SaveGoal(string goal)
        {
            SavedGoals.Add(goal);
        }

    }


}