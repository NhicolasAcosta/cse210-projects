using System;
using System.Collections.Generic;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {  
            Menu myMenu = new Menu();
            int choice = 1;
            while (choice != 6)
            {
                myMenu.DisplayMenu();
                choice = myMenu.GetChoice();
                switch (choice)
                {
                    case 1:
                        myMenu.CreateNewGoal();
                        break;
                    case 2:
                        myMenu.LeastGoals();
                        break;
                    default:
                        Console.WriteLine("Incorrect Option");
                        break;
                }
            }


        }
    }
}
