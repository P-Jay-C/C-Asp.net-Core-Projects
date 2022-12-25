// See https://aka.ms/new-console-template for more information

string demo = "Hello, I am here";
demo.PrintToConsole();


simpleLogger logger = new simpleLogger();
logger.LogError("This is an error");
public static class ExtendedSimpleLogger
{
    public static void LogError(this simpleLogger logger, string message)
    {
        var defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;

        logger.Log(message, "Error");
        Console.ForegroundColor = defaultColor;


    }
}

public class simpleLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void Log(string message, string messageType)
    {
        Log($"{messageType}: {message}");
    }
}