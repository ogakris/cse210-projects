Journal journal = new Journal();

PromptGenerator promptGenerator = new PromptGenerator();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Please select one of the following choices");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");

    Console.Write("What would you like to do? ");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            running = false;
            break;
    }
}