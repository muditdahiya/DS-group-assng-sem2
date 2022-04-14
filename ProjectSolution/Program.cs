//MAIN

//tables array with 10 empty tables
Table[] tables = new Table[10];

//singleton class Menu
Menu menu = Menu.GetInstance();

//queue of orders
Queue<Order> orders = new Queue<Order>();

int choice = 0;
while (choice != -1)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n" + "What would you like to do?");

    Console.WriteLine("1. Add new customer");
    Console.WriteLine("2. Checkout customer");
    Console.WriteLine("3. Take order");
    Console.WriteLine("4. Calculate tips");
    Console.WriteLine("-1. Close restaurant for the day");

    Console.Write("\n" + "Enter option: ");
    
    string input = Console.ReadLine();
    Console.WriteLine();

    try
    {
        choice = Int32.Parse(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("That is not a valid option");
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine("Added new customer to table xyz");
            break;
        case 2:
            Console.WriteLine("Generate bill");
            break;
        case 3:
            Console.WriteLine("Taking order from table xyz");
            break;
        case 4:
            Console.WriteLine("Calculating tips for the dat");
            break;
        case -1:
            Console.WriteLine("Bye");
            break;
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
}

