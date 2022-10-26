using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind;

public abstract class Main
{
    private readonly Game _game;
    private readonly IGameView _gameView;

    public Main()
    {
        _game = new Game();
        _gameView = CreateGameView(_game);
    }

    protected abstract IGameView CreateGameView(Game game);

    public void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }
}
