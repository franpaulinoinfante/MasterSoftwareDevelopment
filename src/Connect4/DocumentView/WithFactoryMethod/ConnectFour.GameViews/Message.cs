namespace ConnectFour.GameViews;

public enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    TurnOf,
    EnterNumOfPlayers,
    EnterColunmToDrop,
    RandomlyColunmToDrop,
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
        " | ",
        "Turn of:",
        "Enter the number of players [0 - 2]: ",
        "Enter a colunm to drop a token: ",
        "Randomly in the column: #colunm",
        "Player -> #token, WIN!!! : -)",
        "TIE!!!",
        "Do you want to continue"
    };

    public static string GetMessage(this Message message)
    {
        return Messages[(int)message];
    }
}
