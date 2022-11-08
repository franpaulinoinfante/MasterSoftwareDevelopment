using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCases;

internal class StartView : WithGameView
{
    public StartView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        new MessageView().WriteLine(Message.Title);
        new BoardView().Write(_game);
    }
}