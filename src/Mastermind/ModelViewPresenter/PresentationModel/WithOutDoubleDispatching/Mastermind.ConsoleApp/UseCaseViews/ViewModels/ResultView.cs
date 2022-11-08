using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCaseViews.ViewModels;

internal class ResultView
{
    internal void WriteLine(MessageCode messageCode, int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage().Replace("#blacks", $"{blacks}").Replace("#whites", $"{whites}"));
    }

    internal void WriteLine(bool isWinner)
    {
        MessageCode messageCode = MessageCode.Looser;
        if (isWinner)
        {
            messageCode = MessageCode.Winner;
        }
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage());
    }
}