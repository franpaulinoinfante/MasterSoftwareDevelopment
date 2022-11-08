using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind;

public abstract class Mastermind
{
    private readonly Game _game;
    private readonly IGameView _gameView;

    public Mastermind()
    {
        _game = new Game();
        _gameView = CreateGameView(_game);
    }

    protected abstract IGameView CreateGameView(Game game);

    protected void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }
}
