using ProjectSolution;
//MAIN

//tables array with 10 empty tables
Table[] tables = new Table[10];
//populating tables array
//table numbers vary from 0 to 9
for (int i = 0; i < tables.Length; i++)
{
    tables[i] = new Table(i);
}

//singleton class Menu
Menu menu = Menu.GetInstance();

//queue of orders
Queue<Order> orders = new Queue<Order>();

//tips for servers
TipJar tipJar = new TipJar();

int choice = 0;
while (choice != -1)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n" + "What would you like to do?");

    Console.WriteLine("1. New customer"); //create customer and assign to table
    Console.WriteLine("2. Checkout customer"); //generate bill, empty table
    Console.WriteLine("3. Take order"); //generate order and assign to customer
    Console.WriteLine("4. Calculate tips"); //sum the TipJar
    Console.WriteLine("-1. Close restaurant for the day"); //can use some facade here

    Console.Write("\n" + "Enter option: ");
    
    //string to take user input
    string userInput = Console.ReadLine();
    Console.WriteLine();

    try
    {
        choice = Int32.Parse(userInput);
    }
    catch (FormatException)
    {
        Console.WriteLine("That is not a valid option");
        //continue to skip switch statement
        continue;
    }

    switch (choice)
    {
        case 1:
            //create customer and assign to table
            {
                //get customer data
                Console.Write("Age of customer: ");
                int age;
                while (true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                        age = Int32.Parse(userInput);
                        //if parse was successful, end the while loop
                        break;
                    }
                    catch (FormatException)
                    {
                        //if exception then take input again
                        Console.WriteLine("Enter integer age.");
                    }
                }

                Console.Write("Is customer a student? (y / n) ");
                bool student;
                while (true)
                {
                    userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        student = true;
                        break;
                    }
                    else if (userInput == "n")
                    {
                        student = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter y or n only");
                    }
                }

                //get customer instance
                Customer customer = CustomerFactory.GetCustomer(age, student);

                //look for an empty table and assign to table
                //boolean to check if an unoccupied table is found or not
                bool foundTable = false;
                foreach (var table in tables)
                {
                    //if table is not occupied then 
                    if (!table.IsOccupied)
                    {
                        //set customer to that table and set occupied to true
                        table.Customer = customer;
                        table.IsOccupied = true;
                        foundTable = true;
                        break;
                    }
                }

                //if table not found then output
                if (!foundTable)
                {
                    Console.WriteLine("All tables are occupied.");
                }
            }
            break;

        case 2:
            //generate bill, ask tip, empty table,
            {
                Console.Write("Table number you would like to checkout: ");
                int number;
                while (true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                        number = Int32.Parse(userInput);
                        //if parse was successful, end the while loop
                        break;
                    }
                    catch (FormatException)
                    {
                        //if exception then take input again
                        Console.WriteLine("Enter valid table number.");
                    }
                }

                //keeping the table as a variable for easy access
                Table currentTable = tables[number];

                if (!currentTable.IsOccupied)
                {
                    Console.WriteLine("This table isn't occupied, cannot checkout.");
                }
                else
                {
                    currentTable.Checkout();
                    currentTable.IsOccupied = false;
                }
            }
            break;

        case 3:
            //generate order and assign to table
            {
                Console.Write("Take order for table number : ");
                int number;
                while (true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                        number = Int32.Parse(userInput);
                        //if parse was successful, end the while loop
                        break;
                    }
                    catch (FormatException)
                    {
                        //if exception then take input again
                        Console.WriteLine("Enter valid table number.");
                    }
                }

                //get table order 
                Order order = tables[number].Order;

                //TODO show menu
                menu.Display();
                //take user choices
                Console.Write("Select item: ");
                int item;
                while (true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                        item = Int32.Parse(userInput);
                        //if parse was successful, end the while loop
                        break;
                    }
                    catch (FormatException)
                    {
                        //if exception then take input again
                        Console.WriteLine("Enter valid item number.");
                    }
                }
                Console.Write("Quantity : ");
                int qty;
                while (true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                        qty = Int32.Parse(userInput);
                        //if parse was successful, end the while loop
                        break;
                    }
                    catch (FormatException)
                    {
                        //if exception then take input again
                        Console.WriteLine("Enter valid item number.");
                    }
                }

                //TODO add item to order
                tables[number].Order.AddItem(item, qty);

                //send order to kitchen
                
            }

            break;

        case 4:
            //sum the TipJar
            {
                Console.WriteLine("Implement in progress");
            }
            
            break;

        case -1:
            Console.WriteLine("Bye");
            break;

        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
}

