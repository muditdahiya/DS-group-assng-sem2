//use singleton here

namespace ProjectSolution
{
    internal class Menu
    {
        // Default private constructor for menu since it is singleton
        private Menu() { }

        private static Menu? MenuInstance = null; // Unique menu instance

        // List of menu components
        // Can be hold either MenuItem or Menu if we consider different types of menus
        private List<IMenuItem> MenuComponents = new List<IMenuItem>()
                                                        { new MenuItem(1, "Pizza", 4.5),
                                                          new MenuItem(2, "Burger", 7),
                                                          new MenuItem(3, "Pasta", 9),
                                                          new MenuItem(4, "Coffee", 3),
                                                          new MenuItem(5, "Tea", 4)}; // Add some items to the list 
        
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
            Console.WriteLine("S.No | Name     | Price");
            // Iterate through all items 
            foreach (var item in MenuComponents)
            {
                item.Display(); // will display MenuItem
            }
        }

        public IMenuItem GetMenuItem(int menuItemId)
        {
            return MenuComponents.First(x => x.id == menuItemId);
        }
    }

    // Item class which holds information about a particular item
    // Has name of the item and price
    internal class MenuItem : IMenuItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public MenuItem(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        // Displays Menu Item
        public void Display()
        {
            Console.WriteLine($"{(id+".").PadRight(5)}| {name.PadRight(9)}| ${price}");

        }
    }

    // Component interface which contains common method for Menu and a MenuItem
    internal interface IMenuItem
    {
        int id { get; set; }
        string name { get; set; }
        double price { get; set; }
        void Display();
    }
}
