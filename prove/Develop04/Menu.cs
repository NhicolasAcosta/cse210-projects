using System;

namespace Develop04
{
    public class Menu
    {
        public int option;
        public void DisplayOptions()
        {
            Console.WriteLine("");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
        }

        public int GetOptions()
        {
            Console.WriteLine("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}