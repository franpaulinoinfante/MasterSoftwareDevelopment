using ConnectFour.GameViews;
using ConnectFour.Models;

namespace ConnectFour;

public abstract class ConnectFour
{
    private readonly Game _game;
    private readonly GameView _gameView;

    public ConnectFour()
    {
        _game = new Game();
        _gameView = CreateGameView(_game);
    }

    protected abstract GameView CreateGameView(Game game);

    protected void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.IsResume());
    }
}
