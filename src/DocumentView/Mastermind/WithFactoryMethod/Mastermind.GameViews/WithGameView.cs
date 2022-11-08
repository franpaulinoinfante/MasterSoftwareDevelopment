using Mastermind.Models;

namespace Mastermind.GameViews;

public abstract class WithGameView
{
    protected internal Game _game;

    protected WithGameView(Game game)
    {
        _game = game;
    }
}
