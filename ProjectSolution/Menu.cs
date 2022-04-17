//use singleton here

namespace ProjectSolution
{
    internal class Menu : IMenuComponent
    {
        // Default private constructor for menu since it is singleton
        private Menu() { }

        private static Menu? MenuInstance = null; // Unique menu instance

        // List of menu components
        // Can be hold either MenuItem or Menu if we consider different types of menus
        private List<IMenuComponent> MenuComponents = new List<IMenuComponent>()
                                                        { new MenuItem("Pizza", 4.5),
                                                          new MenuItem("Burger",7),
                                                          new MenuItem("Pasta",9),
                                                          new MenuItem("Coffee",3),
                                                          new MenuItem("Tea",4)}; // Add some items to the list 


        
        // Returns unique instance of Menu 
        public static Menu GetInstance()
        {
            if(MenuInstance == null)
            {
                MenuInstance =  new Menu();
            }
            return MenuInstance;
        }

        // Method to display the menu
        // Displays all menu components inside MenuComponents list
        public void Display()
        {
            Console.WriteLine("Name\tPrice");
            // Iterate through all items 
            foreach (var item in MenuComponents)
            {
                item.Display(); // will display MenuItem
            }
        }
    }

    // Item class which holds information about a particular item
    // Has name of the item and price
    internal class MenuItem : IMenuComponent
    {
        string name;
        double price;

        public MenuItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        // Displays Menu Item
        public void Display()
        {
            Console.WriteLine("{0}\t${1}",name,price);

        }
    }

    // Component interface which contains common method for Menu and a MenuItem
    internal interface IMenuComponent
    {
        void Display();
    }



}
