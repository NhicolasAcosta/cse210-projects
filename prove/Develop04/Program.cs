using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu newMenu = new Menu();
            Breathing breathingExcersice = new Breathing();
            Reflecting reflectingExcersice = new Reflecting();
            Listing listingExcersice = new Listing();

            newMenu.DisplayOptions();
            int menu = newMenu.GetOptions();
            while (menu != 4)
            {
                if (menu == 1)
                {
                    breathingExcersice.StartBreathing();
                    newMenu.DisplayOptions();
                    menu = newMenu.GetOptions();
                }
                else if (menu == 2)
                {
                    reflectingExcersice.StartReflecting();
                    newMenu.DisplayOptions();
                    menu = newMenu.GetOptions();
                }
                else if (menu == 3)
                {
                    listingExcersice.StartListing();
                    newMenu.DisplayOptions();
                    menu = newMenu.GetOptions();
                }
                else if (menu == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This Options doesn't exist. Choose again!");
                    newMenu.DisplayOptions();
                    menu = newMenu.GetOptions();
                }
            }

        }
    }
}