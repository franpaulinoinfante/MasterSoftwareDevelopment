using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;

internal class ResultView
{
    internal void WriteLine(Game game, int position)
    {
        new MessageView().WriteLine(MessageCode.Result, game.GetBlacks(position), game.GetWhites(position));
    }
}