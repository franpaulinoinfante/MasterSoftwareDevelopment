using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCasesViews.Models;

internal class ResultView
{
    private readonly Logic _logic;

    public ResultView(Logic logic)
    {
        _logic = logic;
    }

    internal void WriteLine(int position)
    {
        new MessageView(MessageCode.Results).WriteLine(_logic.GetBlacks(position), _logic.GetWhites(position));
    }

    internal void WriteLine()
    {
        MessageCode messageCode = MessageCode.Looser;
        if (_logic.IsWinner())
        {
            messageCode = MessageCode.Winner;
        }
        new MessageView(messageCode).WriteLine();
    }
}