using System;
using CMC.Input;
using ReusableUserInterface;

namespace CMC.ReusableUserInterface
{
    internal class UserInterface
    {
        // *******************************
        // Fields
        // *******************************
        //string[] menuItems;

        // *******************************
        // Properties
        // *******************************

        // *******************************
        // Public methods
        // *******************************

        // selection result
        public MenuOptions GetMenuSelection()
        {
            int itemCount = Enum.GetNames(typeof(MenuOptions)).Length;

            ShowGreeting();
            ShowMainMenu();

            int result = GetInput.AsInt("Make Selection", 0, itemCount);
            MenuOptions selection = (MenuOptions)result;

            return selection;
        }

        public (int id, string name, decimal price) GetNewItem()
        {
            int id = GetInput.AsInt("id");
            string name = GetInput.AsString("name");
            decimal price = GetInput.AsDecimal("price");

            return (id, name, price);
        }

        public void ShowItem(string item)
        {
            if (item != null)
            { Console.WriteLine(item); }
        }

        public void ShowItemList(string[] itemList)
        {
            foreach (string item in itemList)
            {
                ShowItem(item);
            }
        }

        // success

        // error

        // exit
        public void ShowExit()
        {
            Console.WriteLine("Exiting");
        }

        // *******************************
        // Private methods
        // *******************************

        // return selection
        // greeting
        private void ShowGreeting()
        {
            Console.WriteLine("Greetings");
        }

        // main menu
        private void ShowMainMenu()
        {
            for (int currentMenuNumber = 0; currentMenuNumber < Enum.GetNames(typeof(MenuOptions)).Length; currentMenuNumber++)
            {
                Console.WriteLine($"{currentMenuNumber}. {(MenuOptions)currentMenuNumber}");
            }
            Console.WriteLine();
        }


        // selection prompt

        // *******************************
        // Constructors
        // *******************************
        public UserInterface()
        {
            //this.menuItems = menuItems;
        }
    }
}
