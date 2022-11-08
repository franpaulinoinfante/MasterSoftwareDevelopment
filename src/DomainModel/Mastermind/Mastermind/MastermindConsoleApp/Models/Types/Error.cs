using MastermindConsoleApp.ConsoleIOs;

namespace MastermindConsoleApp.Models.Types;

internal enum Error
{
    Duplicated,
    WrongCharacters,
    WrongLength,
    Null
}

internal static class ExtensionErrorType
{
    private static readonly string[] Errors =
    {
        "Repeated color",
        "Wrong colors, they must be: #replace",
        "Wrong proposed combination length",
        ""
    };

    internal static void WriteLine(this Error errorType)
    {
        if (errorType != Error.Null)
        {
            ConsoleIO.GetInstance().WriteLine(Errors[(int)errorType]);
        }
    }

    internal static void WriteLine(this Error errorType, Color[] colorTypes)
    {
        string replace = string.Empty;
        for (int i = 0; i < colorTypes.Length; i++)
        {
            replace += colorTypes[i].GetColorType().ToLower();
        }
        ConsoleIO.GetInstance().WriteLine(Errors[(int)errorType].Replace("#replace", replace));
    }

    internal static string ToString(this Error errorType)
    {
        return Errors[(int)errorType];
    }
}
