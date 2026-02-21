using CMC.ReusableUserInterface;
using System;

namespace ReusableUserInterface
{
    public enum MenuOptions
    {
        Exit,
        PrintAll,
        Add,
        Remove,
        Search
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //mockups
            int mockItemListCount = 10;
            string[] mockItemList = new string[mockItemListCount];
            for (int i = 0; i < mockItemListCount; i++)
            {
                mockItemList[i] = "test test test " + i;
            }




            bool IsExitInput = false;

            //string[] menuItems = { "Exit", "Print All", "Add", "Remove", "Search" };
            UserInterface ui = new UserInterface();

            while (!IsExitInput)
            {
                MenuOptions menuSelection = ui.GetMenuSelection();
                bool mockIsItemFound;

                switch (menuSelection)
                {
                    case MenuOptions.Exit:
                        ui.ShowExit();
                        IsExitInput = true;
                        break;
                    case MenuOptions.PrintAll:
                        ui.ShowItemList(mockItemList);
                        break;

                    case MenuOptions.Add:
                        //(int id, string name, decimal price) newItem = ui.GetNewItem();
                        //// item class . add new item
                        //// item class . find item
                        // mockIsItemFound = true;
                        //ui.ShowAddResult(mockIsItemFound);
                        break;

                    case MenuOptions.Remove:
                        //int id = ui.GetRemoveItemID();
                        //// item class . find item
                        // mockIsItemFound = true;
                        //string mockItemToString = " ";
                        //ui.GetRemoveConfirmation(mockItemToString);
                        //// item class . remove item with 
                        //bool mockRemoveResult = true;
                        //ui.ShowRemoveResult(mockRemoveResult);
                        break;

                    case MenuOptions.Search:
                        //// ui . get id
                        //int id = ui.GetSearchID();
                        //// item class . find item
                        //string mockItemClassSearchResults = "";
                        //// ui . display results
                        //ui.ShowItem(mockItemClassSearchResults);
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
