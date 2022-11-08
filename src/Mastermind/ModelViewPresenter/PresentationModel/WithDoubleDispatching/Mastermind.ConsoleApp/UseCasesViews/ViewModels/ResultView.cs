using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;

internal class ResultView
{
    internal void WriteLine(int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(MessageCode.Results.GetMessage().Replace("#blacks", $"{blacks}").Replace("#whites", $"{whites}"));
    }

    internal void WriteLine(bool isWinner)
    {
        MessageCode messageCode = MessageCode.Winner;
        if (!isWinner)
        {
            messageCode = MessageCode.Looser;
        }
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage());
    }
}