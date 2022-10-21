using MastermindConsoleApp.ConsolesIOs;

namespace MastermindConsoleApp.Models.Types;

internal enum MessageType
{
    Title,
    SecretCombination,
    Attempts,
    ProposeCombination,
    Results,
    Winner,
    Looser,
    Resume
}

internal static class Extension
{
    private static string[] Messages =
    {
        "----- MASTERMIND -----",
        "****",
        "#attempts attempt(s): ",
        "Propose a combination: ",
        " --> #blacks blacks and #whites whites",
        "You've won!!! ;-)",
        "You've lost!!! :-(",
        "Do you want to continue"
    };

    internal static void WriteLine(this MessageType messageType)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType]);
    }

    internal static void WriteLine(this MessageType messageType, int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType]
            .Replace("#blacks", $"{ blacks }")
            .Replace("#whites", $"{ whites }"));
    }

    internal static void WriteLine(this MessageType messageType, int attemps)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType].Replace("#attempts", $"{attemps}"));
    }

    internal static string GetToString(this MessageType messageType)
    {
        return Messages[(int)messageType];
    }
}