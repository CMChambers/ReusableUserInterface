using System;
using CMC.Input;

namespace CMC.ReusableUserInterface
{
    internal class UserInterface
    {
        string[] menuItems;

        public UserInterface(string[] menuItems)
        {
            this.menuItems = menuItems;
        }

        // return selection
        public int GetMenuSelection()
        {
            int itemCount = menuItems.Length;

            ShowGreeting();
            ShowMainMenu(menuItems);

            int result = GetInput.AsInt("Make Selection", 0, itemCount);

            return 0;
        }

        // greeting
        private void ShowGreeting()
        {
            Console.WriteLine("Greetings");
        }

        // main menu
        private void ShowMainMenu(string[] menuItems)
        {
            foreach (string item in menuItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        // selection prompt
        public (int id, string name, decimal price) GetNewItem()
        {
            int id = GetInput.AsInt("id");
            string name = GetInput.AsString("name");
            decimal price = GetInput.AsDecimal("price");

            return (id, name, price);
        }

        // selection result

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

    }
}
