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
    string prompt = promptGenerator.GetRandomPrompt();
    Console.WriteLine(prompt);

    Console.Write("> ");
    string response = Console.ReadLine();

    Entry entry = new Entry();
    entry._date = DateTime.Now.ToShortDateString();
    entry._promptText = prompt;
    entry._entryText = response;

    journal.AddEntry(entry);
            break;
        case "2":
            journal.DisplayAll();
            break;
        case "3":
    Console.Write("Enter filename: ");
    string loadFile = Console.ReadLine();
    journal.LoadFromFile(loadFile);
            break;
        case "4":
    Console.Write("Enter filename: ");
    string saveFile = Console.ReadLine();
    journal.SaveToFile(saveFile);
            break;
        case "5":
            running = false;
            break;
    }
}
