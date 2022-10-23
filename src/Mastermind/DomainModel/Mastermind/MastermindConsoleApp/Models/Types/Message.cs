using MastermindConsoleApp.ConsoleIOs;

namespace MastermindConsoleApp.Models.Types;

internal enum Message
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
    private static readonly string[] Messages =
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

    internal static void WriteLine(this Message messageType)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType]);
    }

    internal static void WriteLine(this Message messageType, int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType]
            .Replace("#blacks", $"{blacks}")
            .Replace("#whites", $"{whites}"));
    }

    internal static void WriteLine(this Message messageType, int attempts)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageType].Replace("#attempts", $"{attempts}"));
    }

    internal static string GetToString(this Message messageType)
    {
        return Messages[(int)messageType];
    }
}