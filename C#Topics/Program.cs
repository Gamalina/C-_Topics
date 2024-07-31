using System;

class Program()
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("");
            Console.WriteLine("Please type a command to run the corresponding example");
            Console.WriteLine("The following commands available are: ");
            Console.WriteLine("Dictionary/dict");
            Console.WriteLine("Set");

            Console.WriteLine("Exit - To exit program.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "set":
                    Sets.Main();
                    break;
                case "dictionary" or "dict":
                    Example.Main();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Invalid input. Please type 'set' or 'dictionary'.");
                    break;
            }
        }
    }
}