using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05
{
    public class Goals
    {
        private string typeGoal;
        private string name;
        private string description;
        private int associatedPoints;
        public bool isDone = false;
        private int generalPoints = 0;

        public int GetGeneralPoints()
        {
            return generalPoints;
        }


/********* NAME ************/
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void SetName()
        {
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
        }
        public string GetName()
        {
            return name;
        }

/********* DESCRIPTION ************/
        public string Description
        {
            get{ return description; }
            set{ description = value; }
        }
        public void SetDescription()
        {
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
        }
        public string GetDescription()
        {
            return description;
        }

/********* ASSOCIATED POINTS ************/
        public int AssociatedPoints
        {
            get{ return associatedPoints; }
            set{ associatedPoints = value; }
        }
        public void SetAssociatedPoints()
        {
            Console.WriteLine("What is the amount of points associated with this goal? ");
            associatedPoints = int.Parse(Console.ReadLine());
        }
        public int GetAssociatedPoints()
        {
            return associatedPoints;
        }


/********* TYPE OF GOAL ************/
        public void DisplayTypeGoalOption()
        {
            Console.WriteLine("The type of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create? ");
        }

        public string TypeGoal
        {
            get{ return typeGoal; }
            set{ typeGoal = value; }
        }
        public void SetTypeGoal()
        {
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    typeGoal = "Simple";
                    break;
                case 2: 
                    typeGoal = "Eternal";
                    break;
                case 3:
                    typeGoal = "Checklist";
                    break;
                default:
                    throw new ArgumentException("You didn't choose a correct option");
            }
        }
        public string GetTypeGoal()
        {
            return typeGoal;
        }


        /********* XXXXXXXXXXXXXXXXXXX ************/

        public virtual void DisplayGoals(List<string> splitedGoal, int num)
        {
            Console.WriteLine("The Goals are: ");
            string typeGoal = splitedGoal[0];
            string name = splitedGoal[1];
            string description = splitedGoal[2];
            string associatedPoints = splitedGoal[3];
            string isDone = splitedGoal[4];
            if (isDone == "false")
            {
                Console.WriteLine($"{num}. [ ] {name} ({description})");
            }
            else
            {
                Console.WriteLine($"{num}. [X] {name} ({description})");
            }
            num++;
        }


    }
}


