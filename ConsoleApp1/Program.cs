int select = 1;

do
{
    Console.Clear();
    printOptions(select);

    ConsoleKeyInfo info = Console.ReadKey(true);

    if (info.Key == ConsoleKey.DownArrow)
    {
        if (select == 4) select = 1;
        else
            select++;
    }

    else if (info.Key == ConsoleKey.UpArrow)
    {
        if (select == 1) select = 4;
        else
            select--;
    }

    else if (info.Key == ConsoleKey.Enter)
    {
        if (select == 1)
        {
            Console.Clear();
            Console.WriteLine("New Game loading...");
            Console.WriteLine("\nPlease enter backspace button to go back to main menu...");

            while (info.Key != ConsoleKey.Backspace)
            {
                info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    break;
                }

            }

        }

        else if (select == 2)
        {
            Console.Clear();
            Console.WriteLine("About Game loading...");
            Console.WriteLine("\nPlease enter backspace button to go back to main menu...");

            while (info.Key != ConsoleKey.Backspace)
            {
                info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    break;
                }

            }
        }

        else if (select == 3)
        {
            Console.Clear();
            Console.WriteLine("Settings loading...");
            Console.WriteLine("\nPlease enter backspace button to go back to main menu...");

            while (info.Key != ConsoleKey.Backspace)
            {
                info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    break;
                }

            }
        }
        else if (select == 4)
        {
            Console.Clear();
            Console.WriteLine("Bye bye...");
            Thread.Sleep(500);
            break;
        }
    }

} while (true);


void printOptions(int select)
{
    string[] arr = new string[] { "New Game", "About Game", "Settings", "Exit" };

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == select - 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t\t\t=>{arr[i]}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
            Console.WriteLine($"\t\t\t\t{arr[i]}");
    }
}
