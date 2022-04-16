
using System.Collections.Generic;
namespace ProjectSolution
{
   
    internal class Order

    {//TO DO : "Menu" changes in accordance with Mihir's Menu item's object name (Eg: Burger, Fries etc.)
     //MenuItems contains the list of items Customers ordered
     //Menu is the Menu item name and int is the number of that Menu item ordered
        private Dictionary<Menu, int> MenuItems;

        //Pointer for Customer that's placing the order (association)
        private Customer* CustomerName;

        //Constructor with customer * parameter creates order for that customer
        public Order(Customer* CustName)
        {
            //CustomerName pointer created
            CustomerName = CustName;
            MenuItems = new Dictionary<Menu, int>();

        }
        //Adding items to the order
        public void AddItem(Menu item, int quantity)
        {//checks if item exists in MenuItems 
            if (MenuItems.ContainsKey(item)) 
            {
                MenuItems[item] += quantity; //to add quantity to already existing order quantity
            }
            else
            {
                MenuItems.Add(item, quantity); //adding a key / value using the Add() method
            }
        }

        //Removing items from the order
        public void RemoveItem(Menu item, int quantity)
        {   //checks if item exists already in the order list
            if (MenuItems.ContainsKey(item)) 
            {
                MenuItems[item] -= quantity; //to remove quantity to already existing order quantity

                if (MenuItems[item] <= 0) //item can only size down till 1 cannot be negative & NIL (0) value
                {
                    MenuItems.Remove(item, quantity);  //removing a key / value using the Remove() method
                }
            }
            else 
            {
                Console.WriteLine("The item you are trying to remove does not exist"); //for when disassociation occurs (items that don't exists cannot be edited)
            }
        }
    }
}
