public static void Addition()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Addition selected....");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("Please enter number one and two for transaction");

    bool error = true;
    while (error)
    {
        try
        {
            Console.Write("please enter number one: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter number two: ");
            int two = Convert.ToInt32(Console.ReadLine());

            int value = one + two;
            Console.WriteLine(@"
            ");
            Console.WriteLine("procces completed");
            Console.WriteLine("number one: " + one);
            Console.WriteLine("number two: " + two);
            Console.WriteLine("value: " + value);
            Console.WriteLine(@"
            ");
            calculator.list1.Add($"Action history name: addition");
            calculator.list1.Add($"number one: {one}");
            calculator.list1.Add($"number two: {two}");
            calculator.list1.Add($"value: {value}");

            error = false;
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input, please enter a valid number.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    Console.WriteLine(@"
    ");
    Console.WriteLine(" Do you want another action? (y/n)");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("=> ");
    Console.ForegroundColor = ConsoleColor.White;
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "y":
            Console.Clear();
            calculator.menu();
            break;

        case "n":
            Console.Clear();
            Console.WriteLine("Calculator shuts down...");
            break;
    }
}
