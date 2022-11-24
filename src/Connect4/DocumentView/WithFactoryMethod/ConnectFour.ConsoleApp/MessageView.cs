using ConnectFour.GameViews;

internal class MessageView
{
    internal void Write(Message message)
    {
        ConsoleIO.Instance.Write(message.GetToString());
    }

    internal void WriteLine(Message message)
    {
        ConsoleIO.Instance.WriteLine(message.GetToString());
    }

    internal void WriteLine(Message playerWin, string token)
    {
        ConsoleIO.Instance.WriteLine(playerWin.GetToString().Replace("#token", token));
    }
}
