namespace ConnectFour.ConsoleApp.Views.ViewsModels;

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
        "--------------------------------------------",
        "| ",
        "Turn: #token",
        "Enter the players [0-2] :",
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
        ConsoleIOs.ConsoleIO.Instance.Write(Messages[(int)message]);
    }

    internal static void WriteLine(this Message message)
    {
        ConsoleIOs.ConsoleIO.Instance.WriteLine(Messages[(int)message]);
    }

    internal static void WriteLine(this Message message, string title)
    {
        ConsoleIOs.ConsoleIO.Instance.WriteLine(Messages[(int)message].Replace("#token", title));
    }

    internal static string GetMessage(this Message message)
    {
        return Messages[(int)message];
    }
}