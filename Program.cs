internal class Program
{
  private static void Main(string[] args)
  {
    // Skriv en velkomest melding
    Console.WriteLine("Welcome to C# File System Input/Output");

    // Ta imot bruker kommando seleksjon
    Console.WriteLine("Please enter a command");
    Console.WriteLine("Available commands:");
    Console.WriteLine("- create");
    Console.WriteLine("- read");
    string? userInput = Console.ReadLine();
    if (userInput == null)
    {
      return;
    }

    // Finne kommandoen
    switch (userInput)
    {
      case "create":
        Console.WriteLine("Creating a file");
        break;
      case "read":
        Console.WriteLine("Reading a file");
        break;
      default:
        Console.WriteLine("Unkown Command");
        break;
    }

    // Kjør Kommandoen
  }
}