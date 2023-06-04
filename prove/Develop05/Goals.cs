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
        public string TypeGoal
        {
            get{ return typeGoal; }
            set{ typeGoal = value; }
        }
        public void SetTypeGoal(int option)
        {
            switch(option)
            {
                case 1:
                    typeGoal = "Simple Goal";
                    break;
                case 2: 
                    typeGoal = "Eternal Goal";
                    break;
                case 3:
                    typeGoal = "Checklist Goal";
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

        public virtual void DisplayGoal(List<string> goalsList)
        {
            Console.WriteLine("The Goals are: ");
        }


    }
}


