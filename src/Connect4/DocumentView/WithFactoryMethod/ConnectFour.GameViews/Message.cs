namespace ConnectFour.GameViews;

public enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    TurnOf,
    EnterNumOfPlayers,
    EnterColunmToDrop,
    RandomColunmToDrop,
    PlayerWin,
    PlayersTie,
    Resume
}

public static class MessageExtension
{
    private static readonly string[] Messages =
    {
        "--- CONNECT 4 ---",
        "----------------------",
        "| ",
        "Turn of:",
        "Enter the number of players [0 - 2]: ",
        "Enter a colunm to drop a token: ",
        "Aleatoriamente en la columna: #columna",
        "#token WIN!!! : -)",
        "TIE!!!",
        "Do you want to continue"
    };

    public static string GetToString(this Message message)
    {
        return Messages[(int)message];
    }
}
