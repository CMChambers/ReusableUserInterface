using CMC.ReusableUserInterface;
using System;

namespace ReusableUserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mockups
            int itemListCount = 10;
            string[] itemList = new string[itemListCount];
            for (int i = 0; i < itemListCount; i++)
            {
                itemList[i] = "test test test " + i;
            }




            bool IsExitInput = false;

            string[] menuItems = { "Exit", "Print All", "Add", "Remove", "Search" };
            UserInterface ui = new UserInterface(menuItems);

            while (!IsExitInput)
            {
                int menuSelection = ui.GetMenuSelection();

                switch (menuSelection)
                {
                    case 0:
                        // exit
                        ui.ShowExit();
                        IsExitInput = true;
                        break;
                    case 1:
                        // print all
                        ui.ShowItemList(itemList);
                        break;
                    case 2:
                        // add
                        (int id, string name, decimal price) newItem = ui.GetNewItem();
                        // pass new item to item class
                        break;
                    case 3:
                        // remove
                        int id = ui.GetRemoveItemID();
                        // item class . find item
                        // ui . get confirmation
                        // item class . remove item with id
                        // ui . display result
                        break;
                    case 4:
                        // search
                        // ui . get id
                        int id = ui.GetSearchID();
                        // item class . find item
                        string itemClassSearchResults = "";
                        // ui . display results
                        ui.ShowItem(itemClassSearchResults);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
