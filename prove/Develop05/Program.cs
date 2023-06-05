using System;
using System.Collections.Generic;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {  
            Menu myMenu = new Menu();
            myMenu.DisplayMenu();
            int choice = myMenu.GetChoice();
            switch (choice)
            {
                case 1:
                    myMenu.CreateNewGoal();
                    break;
                case 2:
                    myMenu.LeastGoals();
                    break;
            }

        }
    }
}
