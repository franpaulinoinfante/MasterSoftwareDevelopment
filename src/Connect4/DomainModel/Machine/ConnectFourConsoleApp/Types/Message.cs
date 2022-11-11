using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp.Types;

internal enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    Turn,
    NumOfPlayers,
    Random,
    EnterColunmToDrop,
    InvalidColunm,
    CompleteColunm,
    PlayerWin,
    PlayersTied,
    Resume
}

internal static class MessageExtension
{
    private static readonly string[] Messages =
    {
        "--- CONNECT 4 ---",
        "-",
        " | ",
        "Turn: #token",
        "Enter the players: ",
        "Aleatoriamente en la columna: #columna",
        "Enter a colunm to drop a token: ",
        "Invalid columnn!!! Values [1-7]",
        "Invalid column!!! It's completed",
        "#token WIN!!! : -)",
        "TIED!!!",
        "Do you want to continue"
    };

    internal static void Write(this Message message)
    {
        ConsoleIO.Instance.Write(Messages[(int)message]);
    }

    internal static void WriteLine(this Message message)
    {
        ConsoleIO.Instance.WriteLine(Messages[(int)message]);
    }

    internal static void WriteLine(this Message message, int value)
    {
        ConsoleIO.Instance.WriteLine(Messages[(int)message].Replace("#columna", value.ToString()));
    }

    internal static void WriteLine(this Message message, string title)
    {
        ConsoleIO.Instance.WriteLine(Messages[(int)message].Replace("#token", title));
    }

    internal static string GetMessage(this Message message)
    {
        return Messages[(int)message];
    }
}
