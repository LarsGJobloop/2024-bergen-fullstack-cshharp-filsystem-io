internal class Program
{
  private static void Main(string[] args)
  {
    // Skriv en velkomest melding
    Console.WriteLine("Welcome to C# File System Input/Output");

    bool quitProgram = false;
    while (!quitProgram)
    {
      // Ta imot bruker kommando seleksjon
      Console.WriteLine("Please enter a command");
      Console.WriteLine("Available commands:");
      Console.WriteLine("- create");
      Console.WriteLine("- read");
      Console.WriteLine("- quit");
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
        case "quit":
          Console.WriteLine("Exiting program");
          return;
        default:
          Console.WriteLine("Unkown Command");
          break;
      }

      // Kjør Kommandoen
    }
  }
}