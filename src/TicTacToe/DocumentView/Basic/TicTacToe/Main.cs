using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe;

public abstract class Main
{
    private readonly Game _game;
    private readonly GameView _gameView;

    public Main()
    {
        _game = new Game();
        _gameView = CreateGameView(_game);
    }

    protected abstract GameView CreateGameView(Game game);

    protected void Play()
    {
        do
        {
            _gameView.SetUpPlayers();
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }
}
