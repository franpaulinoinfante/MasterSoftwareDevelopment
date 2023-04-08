using ConnectFour.GameViews;

internal class MessageView
{
    internal void Write(Message message)
    {
        ConsoleIO.Instance.Write(message.GetMessage());
    }

    internal void WriteLine(Message message)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage());
    }
    internal void WriteLine(Message message, int colunm)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage().Replace("#colunm", $"{colunm}"));
    }

    internal void WriteLine(Message playerWin, string token)
    {
        ConsoleIO.Instance.WriteLine(playerWin.GetMessage().Replace("#token", token));
    }
}
