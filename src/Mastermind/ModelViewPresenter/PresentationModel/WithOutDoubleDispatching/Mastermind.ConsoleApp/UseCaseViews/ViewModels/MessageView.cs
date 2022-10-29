using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCaseViews.ViewModels;

internal class MessageView
{
    internal void WriteLine(MessageCode messageCode)
    {
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage());
    }

    internal void WriteLine(MessageCode messageCode, int attempts)
    {
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage().Replace("#attempts", $"{attempts}"));
    }
}
