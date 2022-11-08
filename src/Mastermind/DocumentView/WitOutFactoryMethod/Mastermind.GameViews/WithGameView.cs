using Mastermind.Models;

namespace Mastermind.GameViews;

public class WithGameView
{
    protected Game _game;

    public WithGameView(Game game)
    {
        _game = game;
    }
}
