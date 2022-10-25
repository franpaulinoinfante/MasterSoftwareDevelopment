using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind;

public abstract class Main
{
    private Game _game;
    private IGameView _gameView;

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

        } while (true);
    }
}
