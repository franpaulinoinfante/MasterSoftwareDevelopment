using Connect4.ConsoleIOs;

namespace Connect4.Models.Types;
internal enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    Turn,
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
