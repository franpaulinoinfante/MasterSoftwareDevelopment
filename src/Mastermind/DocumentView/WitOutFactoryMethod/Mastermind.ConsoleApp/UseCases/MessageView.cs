using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCases;

internal class MessageView
{
    internal void WriteLine(Message message, int attempts)
    {
        ConsoleIO.GetInstance().WriteLine(message.GetString().Replace("#attempts", $"{attempts}"));
    }

    internal void WriteLine(Message message)
    {
        ConsoleIO.GetInstance().WriteLine(message.GetString());
    }

    internal void WriteLine(Message message, int blacks, int whites)
    {
        ConsoleIO.GetInstance().WriteLine(message.GetString().Replace("#blacks", $"{blacks}").Replace("#whites", $"{whites}"));
    }
}