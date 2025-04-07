public static void subtractioncs()
{
    
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("subraction selected...");
    Console.ForegroundColor= ConsoleColor.White;

    Console.WriteLine("Please enter number one and number two for transaction");

    bool error = true;
    while(error)
    {
        try
        {
            Console.WriteLine("please enter number one: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number two: ");
            int two = Convert.ToInt32(Console.ReadLine());

            int value = one - two;
            Console.WriteLine(@"
        ");
            Console.WriteLine("procces completed");
            Console.WriteLine("number one: " + one);
            Console.WriteLine("number two: " + two);
            Console.WriteLine("value: " + value);
            Console.WriteLine(@"
        ");
            calculator.list1.Add("Action history name: Subtraction");
            calculator.list1.Add($"number one: {one}");
            calculator.list1.Add($"number two: {two}");
            calculator.list1.Add($"value: {value}");

            error = false;
        }
        catch(FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input, please enter a valid number.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine(@"
        ");
        Console.WriteLine("do you want another action? (y/n)");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("=> ");
        Console.ForegroundColor = ConsoleColor.White;
        string choice = Console.ReadLine();
        switch(choice)
        {
            case "y":
                Console.Clear();
                calculator.menu();
                break;
                case "n":
                Console.Clear();
                Console.WriteLine("calculator shuts down...");
                break;
        }
    }
}
