using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCasesViews.Models;

internal class MessageView
{
    private readonly MessageCode _messageCode;

    public MessageView(MessageCode messageCode)
    {
        _messageCode = messageCode;
    }

    internal void WriteLine()
    {
        ConsoleIO.GetInstance().WriteLine(_messageCode.GetMessage());
    }

    internal void WriteLine(int attempts)
    {
        ConsoleIO.GetInstance().WriteLine(_messageCode.GetMessage().Replace("#attempts", $"{attempts}"));
    }

    internal void WriteLine(int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(_messageCode.GetMessage().Replace("#blacks", $"{blacks}").Replace("#whites", $"{whites}"));
    }
}