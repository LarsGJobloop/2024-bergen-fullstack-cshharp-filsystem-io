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
    Console.WriteLine("Please specify file to create:");
    string? path = Console.ReadLine();
    if (path == null)
    {
      Console.WriteLine("Could not read from Console (/stdin)");
      return;
    }

    try
    {
      var stream = System.IO.File.Create(path);
      Console.WriteLine($"Created file: {path}");
      stream.Close(); // Vi må fortelle OS at vi er ferdig med filen
    }
    catch (System.Exception)
    {
      Console.WriteLine("Could not create file!");
    }
  }

  static void ReadFile()
  {
    Console.WriteLine("Please specify file to read:");
    string? path = Console.ReadLine();
    if (path == null)
    {
      Console.WriteLine("Could not read from Console (/stdin)");
      return;
    }

    try
    {
      // Les av tekst file "hello.txt"
      string content = System.IO.File.ReadAllText(path);
      // Print den til konsollen
      Console.WriteLine(content);
    }
    catch (System.Exception)
    {
      Console.WriteLine("Could not read file, please try something else!");
    }
  }
}