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

//restaurant object takes care of tables that act as observers of the restaurant
Restaurant restaurant = new Restaurant();
restaurant.open(tables);

//singleton class Menu
Menu menu = Menu.GetInstance();

//kitchen instance to send orders to it
Kitchen kitchen = new Kitchen();

//tips for servers
TipJar tipJar = new TipJar();

int choice = 0;
while (choice != -1)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n" + "What would you like to do?");

    Console.WriteLine("1. New customer"); //create customer and assign to table
    Console.WriteLine("2. Take order"); //generate order and assign to customer
    Console.WriteLine("3. Checkout customer"); //generate bill, empty table
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
                        Console.WriteLine("Enter y or n only.");
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
                        
                        //output
                        Console.WriteLine("Customer got table number: " + table.Number);
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

                //keeping the table as a variable for easy access
                Table currentTable = tables[number];

                //if not occupied then error
                if (!currentTable.IsOccupied)
                {
                    Console.WriteLine("This table isn't occupied, cannot take order.");
                }
                else
                //if occupied then show menu and take order
                {
                    //show menu
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

                    //add item to table order
                    tables[number].Order.AddItem(item, qty);

                    //send order to kitchen
                    kitchen.AddOrder(tables[number].Order);
                }
            }

            break;

        case 3:
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

                //if not occupied then error
                if (!currentTable.IsOccupied)
                {
                    Console.WriteLine("This table isn't occupied, cannot checkout.");
                }
                else
                {
                    Console.Write("Enter the tip amount: ");
                    double tipAmount;
                    while (true)
                    {
                        try
                        {
                            userInput = Console.ReadLine();
                            tipAmount = double.Parse(userInput);
                            //if parse was successful, end the while loop
                            break;
                        }
                        catch (FormatException)
                        {
                            //if exception then take input again
                            Console.WriteLine("Enter decimal number.");
                        }
                    }

                    tipJar.Add(tipAmount);
                    currentTable.Checkout();
                }
            }
            break;

        

        case 4:
            //sum the TipJar
            {
                double sum = tipJar.Sum();
                Console.WriteLine("Tips received today: " + sum);
            }
            
            break;

        case -1:
            {
                //empty the tip jar
                double totalTips = tipJar.Sum();
                Console.WriteLine($"Total Tips Earned: {totalTips}");
                //this will check out all tables
                restaurant.close(tables);
                Console.WriteLine("Bye");
            }
            
            break;

        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
}

