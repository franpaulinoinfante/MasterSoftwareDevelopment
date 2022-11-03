using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp.Types;

internal enum MessageCode
{
    Title,
    HorizontalLine,
    VerticalLine,
    EnterColunm,
    Winner,
    Tie,
    Resume
}

internal static class MessageCodeExtension
{
    private static string[] Messages =
    {
        "Connect-4",
        " -----------------------------",
        " | ",
        "Enter the colunm: ",
        "#player player is the best!!!",
        "The game has ended in a draw",
        "Do you want conitnue? "
    };

    internal static void Write(this MessageCode messageCode)
    {
        ConsoleIO.GetInstance().Write(Messages[(int)messageCode]);
    }

    internal static void WriteLine(this MessageCode messageCode)
    {
        ConsoleIO.GetInstance().WriteLine(Messages[(int)messageCode]);
    }

    internal static void WriteLine(this MessageCode messageCode, string token)
    {
        ConsoleIO.GetInstance().Write(Messages[(int)messageCode].Replace("#player", token));
    }

    internal static string GetMessage(this MessageCode messageCode)
    {
        return Messages[(int)messageCode];
    }


}
