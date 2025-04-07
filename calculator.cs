        public static List<string> list1 = new List<string>();

        public static void menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("welcome to simple calculator...");
            Console.WriteLine("Which action do you want to choose?");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"
[1] Addition
[2] Subtraction
[3] multiplication
[4] division
[5] Average

[6] Action history
[7] exit
                  ");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write("=>");
            Console.ForegroundColor = ConsoleColor.White;
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addition.Addition();
                    break;

                case "2":
                    Subtractioncs.subtractioncs();
                    break;

                case "3":
                    multiplication.Multiplication();
                    break;

                case "4":
                    division.Division();
                    break;

                case "5":
                    Average.average();
                    break;

                case "6":
                    show();
                    break;

                case "7":
                    Console.Clear();
                    break;
            }
        }
        private static void show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("your transaction history");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < calculator.list1.Count; i++)
            {
                Console.WriteLine(calculator.list1[i]);
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
                    menu();
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("Calculator shuts down...");
                    break;
            }
