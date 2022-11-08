using Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCaseViews;

internal class StartView : WithGameView
{
    public StartView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        new MessageView().WriteLine(MessageCode.Title);
        new BoardView().Write(_game);
    }
}