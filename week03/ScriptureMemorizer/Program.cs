using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("Philippians", 4, 13);

            Scripture scripture = new Scripture(
                reference,
                "I can do all things through Christ which strengtheneth me."
            );

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.Write("Press Enter to continue or type 'quit' to finish: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3);
            }
        }
    }
}
