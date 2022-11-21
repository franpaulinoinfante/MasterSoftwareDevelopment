using Mastermind.ConsoleApp.ConsoleIOs;

namespace Mastermind.ConsoleApp.UseCasesViews.Views;

internal enum Message
{
    Title,
    Attempts,
    SecrectCombination,
    ProposedCombination,
    Results,
    Winner,
    Lost,
    Resume
}

internal static class MessageExtension
{
    private static readonly string[] Messages =
    {
        "----- MASTERMIND -----",
        "#attempts attempt(s): ",
        "****",
        "Propose a combination: ",
        " --> #blacks blacks and #whites whites",
        "You've won!!! ;-)",
        "You've lost!!! :-(",
        "Do you want to continue"
    };

    internal static void WriteLine(this Message message)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)message]);
    }

    internal static void WriteLine(this Message message, int attempts)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)message].Replace("#attempts", $"{attempts}"));
    }

    internal static void WriteLine(this Message message, int whites, int blacks)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)message]
            .Replace("#whites", $"{whites}")
            .Replace("#blacks", $"{blacks}"));
    }

    internal static string GetString(this Message message)
    {
        return Messages[(int)message];
    }

    internal static string GetString(this Message message, int value)
    {
        return Messages[(int)message].Replace("#replace", $"{value}");
    }
}
