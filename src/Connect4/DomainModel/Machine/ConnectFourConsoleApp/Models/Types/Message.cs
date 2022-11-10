using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp.Models.Types;

internal enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    Turn,
    Players,
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
        "Turn: ",
        "Enter the players: ",
        "Aleatoriamente en la columna: ",
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

    internal static string GetMessage(this Message message)
    {
        return Messages[(int)message];
    }
}
