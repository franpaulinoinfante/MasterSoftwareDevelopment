using TicTacToe.Models;

namespace TicTacToe.Views;

public abstract class GameView
{
    protected readonly Game _game;

    protected GameView(Game game)
    {
        _game = game;
    }

    public abstract void Start();

    public abstract void SetUpPlayers();

    public abstract void Play();

    public abstract bool Resume();
}
