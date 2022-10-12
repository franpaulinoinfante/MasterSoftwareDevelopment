using TicTacToe.Models;

namespace TicTacToe.Views;

public abstract class WithGameView
{
    protected Game _game;

    protected WithGameView(Game game)
    {
        _game = game;
    }
}
