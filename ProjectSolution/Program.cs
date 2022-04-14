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

    Console.WriteLine("1. New customer"); //create customer and assign to table
    Console.WriteLine("2. Checkout customer"); //generate bill, empty table
    Console.WriteLine("3. Take order"); //generate order and assign to table
    Console.WriteLine("4. Calculate tips"); //sum the TipJar
    Console.WriteLine("-1. Close restaurant for the day"); //can use some facade here

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
            Console.WriteLine("Implement in progress");
            break;
        case 2:
            Console.WriteLine("Implement in progress");
            break;
        case 3:
            Console.WriteLine("Implement in progress");
            break;
        case 4:
            Console.WriteLine("Implement in progress");
            break;
        case -1:
            Console.WriteLine("Bye");
            break;
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
}

