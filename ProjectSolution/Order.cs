
using System.Collections.Generic;
namespace ProjectSolution
{
   
    internal class Order

    {//TO DO : "Menu" changes in accordance with Mihir's Menu item's object name (Eg: Burger, Fries etc.)
     //MenuItems contains the list of items Customers ordered
     //Menu is the Menu item name and int is the number of that Menu item ordered
        public Dictionary<IMenuItem, int> MenuItems;
        private Menu menu;

        //Constructor initiates dictionary
        public Order()
        {
            MenuItems = new Dictionary<IMenuItem, int>();
            menu = Menu.GetInstance();
        }

        //Adding items to the order
        public void AddItem(int id, int quantity)
        {
            var menuItem = menu.GetMenuItem(id);
            //checks if item exists in MenuItems 
            if (MenuItems.ContainsKey(menuItem)) 
            {
                MenuItems[menuItem] += quantity; //to add quantity to already existing order quantity
            }
            else
            {
                MenuItems.Add(menuItem, quantity); //adding a key / value using the Add() method
            }
        }

        //Removing items from the order
        public void RemoveItem(int id, int quantity)
        {
            var menuItem = menu.GetMenuItem(id);

            //checks if item exists already in the order list
            if (MenuItems.ContainsKey(menuItem)) 
            {
                MenuItems[menuItem] -= quantity; //to remove quantity to already existing order quantity

                if (MenuItems[menuItem] <= 0) //item can only size down till 1 cannot be negative & NIL (0) value
                {
                    MenuItems.Remove(menuItem);  //removing a key / value using the Remove() method
                }
            }
            else 
            {
                Console.WriteLine("The item you are trying to remove does not exist"); //for when disassociation occurs (items that don't exists cannot be edited)
            }
        }

        //method to clear the order
        public void Clear()
        {
            MenuItems.Clear();
        }
    }
}
