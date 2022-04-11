//MAIN
int choice = 0;
while (choice != 5)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n" + "What would you like to do?");

    Console.WriteLine("1. Add new customer");
    Console.WriteLine("2. Checkout customer");
    Console.WriteLine("3. Take order");
    Console.WriteLine("4. Calculate tips");
    Console.WriteLine("5. Close restaurant for the day");

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
        case 5:
            Console.WriteLine("Bye");
            break;
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
}

