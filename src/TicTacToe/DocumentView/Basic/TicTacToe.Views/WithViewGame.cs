using TicTacToe.Models;

namespace TicTacToe.Views;

public abstract class WithViewGame
{
    protected Game _game;

    protected WithViewGame(Game game)
    {
        _game = game;
    }
}
