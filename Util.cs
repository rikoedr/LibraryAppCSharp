using System;

public class Util{
    public static string customStringInput(string inputMessage) {
        Console.Write(inputMessage);
        string input = Console.ReadLine();

        return ErrorHandlers.stringCheck(input);
    }

    public static int customIntegerInput(string inputMessage) {
        Console.Write(inputMessage);
        string input = Console.ReadLine();

        return ErrorHandlers.integerParseCheck(input);
    }

    public static void temporaryPauseApp() {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadLine();
    }
}
