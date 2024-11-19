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
          CreateFile();
          break;
        case "read":
          ReadFile();
          break;
        case "quit":
          Console.WriteLine("Exiting program");
          return;
        default:
          Console.WriteLine("Unkown Command");
          break;
      }
    }
  }

  static void CreateFile()
  {
    Console.WriteLine("Creating a file (called from a method)");
  }

  static void ReadFile()
  {
    Console.WriteLine("Reading a file (called from a method)");
  }
}