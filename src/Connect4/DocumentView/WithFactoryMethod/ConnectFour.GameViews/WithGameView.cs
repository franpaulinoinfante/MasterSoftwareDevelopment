using ConnectFour.Models;

namespace ConnectFour.GameViews;

public abstract class WithGameView
{
    protected Game _game;

    protected WithGameView(Game game)
    {
        _game = game;
    }
}
