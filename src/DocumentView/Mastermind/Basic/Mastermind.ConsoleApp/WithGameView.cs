using Mastermind.Models;

namespace Mastermind.ConsoleApp;

internal abstract class WithGameView
{
    protected Game _game;

    protected WithGameView(Game game)
    {
        _game = game;
    }
}
